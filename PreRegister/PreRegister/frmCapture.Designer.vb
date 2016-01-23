<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapture
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCapture))
        Me.pbDisplay = New System.Windows.Forms.PictureBox()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.pcCapture = New System.Windows.Forms.PictureBox()
        Me.pbSave = New System.Windows.Forms.PictureBox()
        Me.pbReCapture = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMemberNo = New System.Windows.Forms.TextBox()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.pcBG = New System.Windows.Forms.PictureBox()
        CType(Me.pbDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pcBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDisplay
        '
        Me.pbDisplay.Location = New System.Drawing.Point(0, 0)
        Me.pbDisplay.Name = "pbDisplay"
        Me.pbDisplay.Size = New System.Drawing.Size(640, 480)
        Me.pbDisplay.TabIndex = 0
        Me.pbDisplay.TabStop = False
        Me.pbDisplay.Visible = False
        '
        'pbImage
        '
        Me.pbImage.Location = New System.Drawing.Point(0, 0)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(640, 480)
        Me.pbImage.TabIndex = 1
        Me.pbImage.TabStop = False
        '
        'pcCapture
        '
        Me.pcCapture.BackColor = System.Drawing.Color.Transparent
        Me.pcCapture.BackgroundImage = CType(resources.GetObject("pcCapture.BackgroundImage"), System.Drawing.Image)
        Me.pcCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcCapture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcCapture.Location = New System.Drawing.Point(277, 488)
        Me.pcCapture.Name = "pcCapture"
        Me.pcCapture.Size = New System.Drawing.Size(91, 39)
        Me.pcCapture.TabIndex = 125
        Me.pcCapture.TabStop = False
        '
        'pbSave
        '
        Me.pbSave.BackColor = System.Drawing.Color.Transparent
        Me.pbSave.BackgroundImage = CType(resources.GetObject("pbSave.BackgroundImage"), System.Drawing.Image)
        Me.pbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSave.Location = New System.Drawing.Point(381, 488)
        Me.pbSave.Name = "pbSave"
        Me.pbSave.Size = New System.Drawing.Size(91, 39)
        Me.pbSave.TabIndex = 126
        Me.pbSave.TabStop = False
        Me.pbSave.Visible = False
        '
        'pbReCapture
        '
        Me.pbReCapture.BackColor = System.Drawing.Color.Transparent
        Me.pbReCapture.BackgroundImage = CType(resources.GetObject("pbReCapture.BackgroundImage"), System.Drawing.Image)
        Me.pbReCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbReCapture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReCapture.Location = New System.Drawing.Point(277, 488)
        Me.pbReCapture.Name = "pbReCapture"
        Me.pbReCapture.Size = New System.Drawing.Size(91, 39)
        Me.pbReCapture.TabIndex = 127
        Me.pbReCapture.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pcBG)
        Me.Panel1.Controls.Add(Me.pbImage)
        Me.Panel1.Controls.Add(Me.pbDisplay)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 480)
        Me.Panel1.TabIndex = 128
        '
        'txtMemberNo
        '
        Me.txtMemberNo.Location = New System.Drawing.Point(489, 489)
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.Size = New System.Drawing.Size(100, 20)
        Me.txtMemberNo.TabIndex = 129
        Me.txtMemberNo.Visible = False
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblClose.Location = New System.Drawing.Point(615, 502)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(27, 25)
        Me.lblClose.TabIndex = 130
        Me.lblClose.Text = "X"
        '
        'pcBG
        '
        Me.pcBG.BackColor = System.Drawing.Color.Transparent
        Me.pcBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pcBG.Image = CType(resources.GetObject("pcBG.Image"), System.Drawing.Image)
        Me.pcBG.Location = New System.Drawing.Point(379, 20)
        Me.pcBG.Name = "pcBG"
        Me.pcBG.Size = New System.Drawing.Size(220, 170)
        Me.pcBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcBG.TabIndex = 131
        Me.pcBG.TabStop = False
        Me.pcBG.Visible = False
        '
        'frmCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 535)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.txtMemberNo)
        Me.Controls.Add(Me.pbSave)
        Me.Controls.Add(Me.pcCapture)
        Me.Controls.Add(Me.pbReCapture)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCapture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCapture"
        CType(Me.pbDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcCapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pcBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbDisplay As System.Windows.Forms.PictureBox
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents pcCapture As System.Windows.Forms.PictureBox
    Friend WithEvents pbSave As System.Windows.Forms.PictureBox
    Friend WithEvents pbReCapture As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtMemberNo As System.Windows.Forms.TextBox
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents pcBG As System.Windows.Forms.PictureBox
End Class
