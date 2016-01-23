Imports ReaderModule
Public Class frmWriteRFIDTag

    Private Sub txtMemberNo_GotFocus(sender As Object, e As EventArgs) Handles txtMemberNo.GotFocus
        txtMemberNo.SelectionStart = 0
        txtMemberNo.SelectionLength = Len(txtMemberNo.Text)
    End Sub

    Private Sub txtMemberNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemberNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            WriteTag()
        End If
    End Sub

    Private Sub ClearForm()
        txtMemberNo.Text = ""
        txtName.Text = ""
        txtPosition.Text = ""
        txtCompany.Text = ""
        txtValidDate.Text = ""
        txtExpireDate.Text = ""
    End Sub

    Private Sub txtMember_TextChanged(sender As Object, e As EventArgs) Handles txtMemberNo.TextChanged

    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPosition.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPosition.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtCompany.TextChanged

    End Sub

    Private Sub frmWriteRFIDTag_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            Dim ini As New IniReader(Application.StartupPath & "\Config.ini")
            ini.Section = "ReaderSetting"

            ReaderParamsEng.CommIntSelectFlag = 1
            ReaderParamsEng.LanguageFlag = 1
            ReadWriteIOEng.comm.PortName = ini.ReadString("Comport")
            ReadWriteIOEng.comm.BaudRate = ini.ReadString("BaudRate")
            ReadWriteIOEng.comm.Open()

            ini = Nothing

            Dim ID(2) As UInt32
            Dim result As Integer = ReaderParamsEng.GetModuleID(ID)
            If result <> 0 Then
                ReadWriteIOEng.comm.Close()
                MessageBox.Show("Module Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub btnWriteTag_Click(sender As Object, e As EventArgs) Handles btnWriteTag.Click
        WriteTag()
    End Sub

    Private Sub WriteTag()
        Dim MemberNo As String = txtMemberNo.Text.Trim
        If MemberNo.Length = 9 Then
            ClearForm()
            'Fill In data
            Dim p As Para.TABLE.ErmTsPersonalInfoPara = Engine.Questionnaire.RegisterENG.GetPersonalInfoByMemberNo(MemberNo)
            If p.ID > 0 Then
                txtMemberNo.Text = MemberNo
                txtName.Text = p.FIRST_NAME & " " & p.LAST_NAME
                txtPosition.Text = p.POSITION_NAME
                txtCompany.Text = p.COMPANY_NAME
                txtValidDate.Text = p.VALID_DATE.Value.ToString("dd MMMM yyyy", New Globalization.CultureInfo("th-TH"))
                txtExpireDate.Text = p.EXPIRE_DATE.Value.ToString("dd MMMM yyyy", New Globalization.CultureInfo("th-TH"))

                Try
                    'Write Tag
                    'Format 58-09-10-00-01-00
                    Dim TagNo As String = MemberNo.Substring(0, 2) & "-" & MemberNo.Substring(2, 2) & "-" & MemberNo.Substring(4, 2) & "-" & MemberNo.Substring(6, 2) & "-" & MemberNo.Substring(8, 1) & "0-00"
                    If ReadWriteIOEng.WriteTag(TagNo, 2, 3) = True Then
                        ReadWriteIOEng.BeefON()
                        Dim ReadTagNo As String = ReadWriteIOEng.ReadTag(2, 3)
                        ReadWriteIOEng.BeefOFF()

                        If TagNo = ReadTagNo Then
                            MessageBox.Show("Write Success", "Write Tag", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ReadWriteIOEng.BeefOFF()
                            MessageBox.Show(ReadWriteIOEng.ErrorMessage, "Write Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        ReadWriteIOEng.BeefOFF()
                        MessageBox.Show(ReadWriteIOEng.ErrorMessage, "Write Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    ReadWriteIOEng.BeefOFF()
                    MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace, "Write Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("No data found", "No data found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ClearForm()
                txtMemberNo.Text = MemberNo
            End If
            p = Nothing
        Else
            MessageBox.Show("รหัสมาชิกต้องมี 9 หลัก", "Invalid Member No", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ClearForm()
            txtMemberNo.Text = MemberNo
        End If
        txtMemberNo.SelectAll()
    End Sub
End Class
