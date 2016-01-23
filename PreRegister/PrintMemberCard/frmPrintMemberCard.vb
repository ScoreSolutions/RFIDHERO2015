Imports System.Drawing.Printing

Public Class frmPrintMemberCard

    Public fn5 As New Font("Tahoma", 5, FontStyle.Regular)
    Public fn8 As New Font("Tahoma", 8, FontStyle.Regular)
    Public fn10 As New Font("Tahoma", 10, FontStyle.Regular)
    Public fn11 As New Font("Tahoma", 11, FontStyle.Regular)
    Public fn12 As New Font("Tahoma", 12, FontStyle.Regular)
    Public fn13 As New Font("Tahoma", 13, FontStyle.Regular)
    Public fn14 As New Font("Tahoma", 14, FontStyle.Regular)
    Public fn16 As New Font("Tahoma", 16, FontStyle.Regular)
    Public fn8b As New Font("Tahoma", 8, FontStyle.Bold)
    Public fn9b As New Font("Tahoma", 9, FontStyle.Bold)
    Public fn10b As New Font("Tahoma", 10, FontStyle.Bold)
    Public fn11b As New Font("Tahoma", 11, FontStyle.Bold)
    Public fn12b As New Font("Tahoma", 12, FontStyle.Bold)
    Public fn13b As New Font("Tahoma", 13, FontStyle.Bold)
    Public fn14b As New Font("Tahoma", 14, FontStyle.Bold)
    Public fn16b As New Font("Tahoma", 16, FontStyle.Bold)
    Public fn24b As New Font("Tahoma", 24, FontStyle.Bold)
    Public fn36b As New Font("Tahoma", 36, FontStyle.Bold)
    Public fn42b As New Font("Tahoma", 42, FontStyle.Bold)
    Public fnBarcode As New Font("IDAutomationHC39M", 10)
    Public lastPrintY As Integer = 0

    Private Sub frmPrintMemberCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub

    Private Sub ShowData()
        Dim sql As String = "select inf.id, inf.member_no, inf.first_name + ' ' + inf.last_name member_name, "
        sql += " case  inf.member_type when '1' then 'สมาชิกทั่วไป' else 'PRESS' end member_type, "
        sql += " inf.valid_date,inf.expire_date, count(pj.id) print_count"
        sql += " from ERM_TS_PERSONAL_INFO inf"
        sql += " left join TB_PRINT_JOB pj on inf.id=pj.erm_ts_personal_info_id"
        sql += " where inf.member_no Is Not null"
        sql += " and inf.member_no like '%" & txtBarcode.Text.Trim & "%'"
        sql += " group by inf.id, inf.member_no, inf.first_name + ' ' + inf.last_name, inf.member_type,"
        sql += " inf.valid_date,inf.expire_date,isnull(inf.update_on,inf.create_on) "
        sql += " order by isnull(inf.update_on,inf.create_on) desc"

        Dim eng As New Engine.Questionnaire.RegisterENG
        Dim dt As DataTable = eng.GetDataTable(sql)
        If dt.Rows.Count > 0 Then
            dgMemberList.AutoGenerateColumns = False
            dgMemberList.DataSource = dt

            For Each grv As DataGridViewRow In dgMemberList.Rows
                If grv.Cells("print_count").Value = 0 Then
                    grv.Cells("btnPrint").Value = "Print"
                    grv.Cells("print_status").Value = "Wait Print"
                Else
                    grv.Cells("btnPrint").Value = "Re Print"
                    grv.Cells("print_status").Value = "Printed"
                End If
            Next
        Else
            dgMemberList.DataSource = Nothing
        End If
        eng = Nothing
    End Sub

    Private Sub dgMemberList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMemberList.CellContentClick

    End Sub

    Private Sub dgMemberList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgMemberList.CellMouseClick
        Dim IsPrint As Boolean = False
        If dgMemberList.Rows.Count > 0 Then
            If dgMemberList.SelectedRows(0).Cells(e.ColumnIndex).Value.ToString = "Print" Then
                IsPrint = True
            ElseIf dgMemberList.SelectedRows(0).Cells(e.ColumnIndex).Value.ToString = "Re Print" Then
                IsPrint = True
            End If

            If IsPrint = True Then
                TimerPrintJob.Enabled = False
                With dgMemberList.SelectedRows(0)
                    If Engine.Questionnaire.RegisterENG.InsertPrintJob(.Cells("id").Value, "frmPrintMemberCard_dgMemberList_CellMouseClick", True) = True Then
                        PrintMemberNo = .Cells("member_no").Value
                        PrintName = .Cells("member_name").Value
                        PrintMemberType = .Cells("member_type").Value
                        PrintValidDate = Convert.ToDateTime(.Cells("valid_date").Value).ToString("dd MMMM yyyy", New Globalization.CultureInfo("th-TH"))
                        'PrintExpireDate = Convert.ToDateTime(.Cells("expire_date").Value).ToString("MM-yy", New Globalization.CultureInfo("en-US"))

                        Dim p As New PrintDocument
                        p.PrintController = New Printing.StandardPrintController
                        Dim ini As New IniReader(Application.StartupPath & "\Config.ini")
                        ini.Section = "PrintSetting"
                        p.PrinterSettings.PrinterName = ini.ReadString("PrinterName")

                        AddHandler p.PrintPage, AddressOf PrintDocument1_PrintPage
                        p.Print()

                        ShowData()
                        MessageBox.Show("Print OK", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With
                TimerPrintJob.Enabled = True
            End If
        End If

    End Sub

    Dim PrintName As String = ""
    Dim PrintMemberNo As String = ""
    Dim PrintMemberType As String = ""
    Dim PrintValidDate As String = ""
    'Dim PrintExpireDate As String = ""

    Private Sub TimerPrintJob_Tick(sender As Object, e As EventArgs) Handles TimerPrintJob.Tick
        TimerPrintJob.Enabled = False
        Try
            Dim dt As DataTable = Engine.Questionnaire.RegisterENG.GetPrintJobData()
            If dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    Dim trans As New Linq.Common.Utilities.TransactionDB
                    Dim PrintJobID As Long = Convert.ToInt64(dr("id"))
                    If Engine.Questionnaire.RegisterENG.chkPrintedJob(PrintJobID, trans) Then
                        If Engine.Questionnaire.RegisterENG.UpdatePrintJob(PrintJobID, trans) Then

                            PrintMemberNo = dr("member_no")
                            PrintName = dr("member_name")
                            PrintMemberType = dr("member_type")
                            PrintValidDate = Convert.ToDateTime(dr("valid_date")).ToString("dd MMMM yyyy", New Globalization.CultureInfo("th-TH"))
                            'PrintExpireDate = Convert.ToDateTime(dr("expire_date")).ToString("MM-yy", New Globalization.CultureInfo("en-US"))

                            Dim p As New PrintDocument
                            p.PrintController = New Printing.StandardPrintController
                            Dim ini As New IniReader(Application.StartupPath & "\Config.ini")
                            ini.Section = "PrintSetting"
                            p.PrinterSettings.PrinterName = ini.ReadString("PrinterName")

                            'p.DefaultPageSettings.PrintableArea = New RectangleF(0, 0, 86, 54)

                            AddHandler p.PrintPage, AddressOf PrintDocument1_PrintPage
                            p.Print()

                            trans.CommitTransaction()
                            System.Threading.Thread.Sleep(2000)
                        Else
                            trans.RollbackTransaction()
                        End If
                    Else
                        trans.RollbackTransaction()
                    End If
                Next
            End If
            dt.Dispose()
        Catch ex As Exception

        End Try
        TimerPrintJob.Enabled = True
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        lastPrintY = 5
        Try
            PrintText("    สมาคม อาร์ เอฟ ไอดี แห่งประเทศไทย", fn14b, Align.Center, e)
            PrintText("   RFID Association of Thailand", fn10, Align.Center, e)

            PrintText(" ", fn5, Align.Left, e)   'เว้นช่องว่าง 1 บรรทัด
            PrintText("   " & PrintMemberType, fn16b, Align.Center, e)  'ประเภทสมาชิก

            'PrintText(" ", fn5, Align.Left, e)   'เว้นช่องว่าง 1 บรรทัด
            PrintText("   " & PrintName, fn14b, Align.Center, e)     'ชื่อสมาชิก
            PrintText("   หมายเลขสมาชิก " & PrintMemberNo, fn10, Align.Center, e)  'หมายเลขสมาชิก
            
            'PrintText(" ", fn5, Align.Left, e)   'เว้นช่องว่าง 1 บรรทัด
            'PrintText("   วันที่ออกบัตร : " & PrintValidDate, fn8, Align.Center, e)

            SetUpFontBarcode()
            'PrintText(" ", fn5, Align.Left, e)   'เว้นช่องว่าง 1 บรรทัด
            PrintText("*" & PrintMemberNo & "*", fnBarcode, Align.Center, e)  'Barcode หมายเลขสมาชิก
        Catch ex As Exception

        End Try
        e.HasMorePages = False
    End Sub

#Region "Print"
    Sub PrintText(ByVal txt As String, ByVal fnt As Font, ByVal align As Int16, ByRef e As System.Drawing.Printing.PrintPageEventArgs)
        Dim w As Integer = e.Graphics.MeasureString(txt, fnt).Width
        Dim h As Integer = e.Graphics.MeasureString(txt, fnt).Height
        'Dim h As Integer = 8
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim brsh As New SolidBrush(Color.FromArgb(0, 0, 0))
        Select Case align
            Case 0 'Default, LEFT
                x = e.PageSettings.PrintableArea.Left
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 1 'CENTER
                'x = e.PageSettings.PrintableArea.Width / 2 - w / 2
                x = (320 / 2) - (w / 2)   'Hard code โลด
                y = e.PageSettings.PrintableArea.Top + lastPrintY

            Case 2 'RIGHT
                x = e.PageSettings.PrintableArea.Right - w
                y = e.PageSettings.PrintableArea.Top + lastPrintY
        End Select
        e.Graphics.DrawString(txt, fnt, brsh, x, y)
        'TextRenderer.DrawText(e.Graphics, txt, fnt, New Point(x, y), SystemColors.ControlText)
        lastPrintY = y + h
    End Sub

    Sub PrintImage(ByVal img As Image, ByVal align As Int16, ByRef e As System.Drawing.Printing.PrintPageEventArgs)
        Dim w As Integer = img.Width
        Dim h As Integer = img.Height
        Dim x As Integer = 0
        Dim y As Integer = 0

        Select Case align
            Case 0 'Default, LEFT
                x = e.PageSettings.PrintableArea.Left
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 1 'CENTER
                x = e.PageSettings.PrintableArea.Width / 2 - w / 2
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 2 'RIGHT
                x = e.PageSettings.PrintableArea.Right - w
                y = e.PageSettings.PrintableArea.Top + lastPrintY
        End Select
        e.Graphics.DrawImage(img, x, y)

        lastPrintY = y + h
    End Sub

    Sub PrintTextImage(ByVal txt As String, ByVal fnt As Font, ByVal img As Image, ByVal align As Int16, ByRef e As System.Drawing.Printing.PrintPageEventArgs)
        Dim w As Integer = img.Width
        Dim h As Integer = img.Height
        Dim wt As Integer = e.Graphics.MeasureString(txt, fnt).Width
        Dim ht As Integer = e.Graphics.MeasureString(txt, fnt).Height
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim brsh As New SolidBrush(Color.FromArgb(0, 0, 0))
        Dim str As String = ""
        Select Case align
            Case 0 'Default, LEFT
                x = e.PageSettings.PrintableArea.Left
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 1 'CENTER
                x = (e.PageSettings.PrintableArea.Width / 2) - ((w + wt + 5) / 2)
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 2 'RIGHT
                x = e.PageSettings.PrintableArea.Right - (w + wt)
                y = e.PageSettings.PrintableArea.Top + lastPrintY
        End Select
        e.Graphics.DrawImage(img, x, y, w, h)
        If InStr(txt, vbCrLf) Then
            Dim font As Font = fnt
            font = New Font("Tahoma", fnt.Size + 1, FontStyle.Bold)
            e.Graphics.DrawString(txt.Split(vbCrLf)(0), font, brsh, x + w + 5, (h - ht) / 2)
            e.Graphics.DrawString(txt.Split(vbCrLf)(1), fnt, brsh, x + w + 5, (((h - ht) / 2) / 2) + (ht / 3))
        Else
            e.Graphics.DrawString(txt, fnt, brsh, x + w + 5, (h - ht) / 2)
        End If
        lastPrintY = y + h
    End Sub

    Public Sub SetUpFontBarcode()
        Dim ini As New IniReader(Application.StartupPath & "\Config.ini")
        ini.Section = "PrintSetting"
        'If ini.ReadString("PaperSize") = 60 Then
        'fn8b = New Font("Tahoma", 6, FontStyle.Bold)
        'fn10b = New Font("Tahoma", 8, FontStyle.Bold)
        fnBarcode = New Font(ini.ReadString("FontBarcode"), ini.ReadString("FontBarcodeSize"))
        ini = Nothing
        'fn12b = New Font("Tahoma", 8, FontStyle.Bold)
        'End If
    End Sub

    Public Enum Align
        Left
        Center
        Right
    End Enum

    Public Function CheckPrinter(ByVal pd As PrintDocument) As Boolean
        Dim ini As New IniReader(Application.StartupPath & "\Config.ini")
        ini.Section = "PrintSetting"
        Dim PrinterName As String = ini.ReadString("PrinterName")
        If pd.PrinterSettings.IsValid Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Enum PrinterStatus
        PrinterIdle = 3
        PrinterPrinting = 4
        PrinterWarmingUp = 5
    End Enum

    Private Function PrinterStatusToString(ByVal ps As PrinterStatus) As String
        Dim str As String = ""
        Select Case ps
            Case PrinterStatus.PrinterIdle
                Return "idle"
            Case PrinterStatus.PrinterPrinting
                Return "printing"
            Case PrinterStatus.PrinterWarmingUp
                Return "warmup"
            Case Else
                Return "unknown"
        End Select
        Return str
    End Function

    Function CheckStatus() As String
        Dim strPrintServer As String
        strPrintServer = "localhost"
        Dim WMIObject As String, PrinterSet As Object, Printer As Object
        WMIObject = "winmgmts://" & strPrintServer
        PrinterSet = GetObject(WMIObject).InstancesOf("win32_Printer")
        Dim ini As New IniReader(Application.StartupPath & "\Config.ini")
        ini.Section = "PrintSetting"
        Dim PrinterName As String = ini.ReadString("PrinterName")
        Dim Status As String = ""
        For Each Printer In PrinterSet
            If PrinterName = Printer.Name Then Status = Printer.PrinterStatus : Exit For
        Next Printer
        Return PrinterStatusToString(Status)
    End Function
#End Region

    Private Sub txtBarcode_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyUp
        ShowData()
    End Sub
End Class
