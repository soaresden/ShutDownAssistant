<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.CmdToSend = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioShut = New System.Windows.Forms.RadioButton()
        Me.RadioLogOff = New System.Windows.Forms.RadioButton()
        Me.RadioReboot = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeToApply = New System.Windows.Forms.TextBox()
        Me.HH = New System.Windows.Forms.TextBox()
        Me.MM = New System.Windows.Forms.TextBox()
        Me.SS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdtosenddefault = New System.Windows.Forms.TextBox()
        Me.TrayShutDownPlan = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdToSend
        '
        Me.CmdToSend.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CmdToSend.Location = New System.Drawing.Point(119, 203)
        Me.CmdToSend.Name = "CmdToSend"
        Me.CmdToSend.Size = New System.Drawing.Size(242, 27)
        Me.CmdToSend.TabIndex = 7
        Me.CmdToSend.Text = "shutdown -s -t 3600"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioShut
        '
        Me.RadioShut.AutoSize = True
        Me.RadioShut.Checked = True
        Me.RadioShut.Location = New System.Drawing.Point(71, 71)
        Me.RadioShut.Name = "RadioShut"
        Me.RadioShut.Size = New System.Drawing.Size(98, 24)
        Me.RadioShut.TabIndex = 3
        Me.RadioShut.TabStop = True
        Me.RadioShut.Text = "ShutDown"
        Me.RadioShut.UseVisualStyleBackColor = True
        '
        'RadioLogOff
        '
        Me.RadioLogOff.AutoSize = True
        Me.RadioLogOff.Location = New System.Drawing.Point(200, 71)
        Me.RadioLogOff.Name = "RadioLogOff"
        Me.RadioLogOff.Size = New System.Drawing.Size(79, 24)
        Me.RadioLogOff.TabIndex = 4
        Me.RadioLogOff.TabStop = True
        Me.RadioLogOff.Text = "LogOut"
        Me.RadioLogOff.UseVisualStyleBackColor = True
        '
        'RadioReboot
        '
        Me.RadioReboot.AutoSize = True
        Me.RadioReboot.Location = New System.Drawing.Point(333, 71)
        Me.RadioReboot.Name = "RadioReboot"
        Me.RadioReboot.Size = New System.Drawing.Size(79, 24)
        Me.RadioReboot.TabIndex = 5
        Me.RadioReboot.TabStop = True
        Me.RadioReboot.Text = "Reboot"
        Me.RadioReboot.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(267, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-8, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 66)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ShutDownPlan.My.Resources.Resources.icon_pc
        Me.PictureBox1.Location = New System.Drawing.Point(33, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(430, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "v1.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(113, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 41)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ShutDownPlan"
        '
        'TimeToApply
        '
        Me.TimeToApply.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TimeToApply.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TimeToApply.Location = New System.Drawing.Point(259, 112)
        Me.TimeToApply.Name = "TimeToApply"
        Me.TimeToApply.Size = New System.Drawing.Size(93, 27)
        Me.TimeToApply.TabIndex = 6
        Me.TimeToApply.Text = "3600"
        Me.TimeToApply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HH
        '
        Me.HH.Location = New System.Drawing.Point(119, 112)
        Me.HH.MaxLength = 2
        Me.HH.Name = "HH"
        Me.HH.Size = New System.Drawing.Size(31, 27)
        Me.HH.TabIndex = 0
        Me.HH.Text = "01"
        Me.HH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MM
        '
        Me.MM.Location = New System.Drawing.Point(156, 112)
        Me.MM.MaxLength = 2
        Me.MM.Name = "MM"
        Me.MM.Size = New System.Drawing.Size(35, 27)
        Me.MM.TabIndex = 1
        Me.MM.Text = "00"
        Me.MM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SS
        '
        Me.SS.Location = New System.Drawing.Point(197, 112)
        Me.SS.MaxLength = 2
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(25, 27)
        Me.SS.TabIndex = 2
        Me.SS.Text = "00"
        Me.SS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "HH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "MM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "SS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ms"
        '
        'cmdtosenddefault
        '
        Me.cmdtosenddefault.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmdtosenddefault.Location = New System.Drawing.Point(119, 170)
        Me.cmdtosenddefault.Name = "cmdtosenddefault"
        Me.cmdtosenddefault.Size = New System.Drawing.Size(242, 27)
        Me.cmdtosenddefault.TabIndex = 15
        Me.cmdtosenddefault.Text = "shutdown -s -t 3600"
        Me.cmdtosenddefault.Visible = False
        '
        'TrayShutDownPlan
        '
        Me.TrayShutDownPlan.Text = "NotifyIcon1"
        Me.TrayShutDownPlan.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(462, 278)
        Me.Controls.Add(Me.cmdtosenddefault)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.MM)
        Me.Controls.Add(Me.HH)
        Me.Controls.Add(Me.TimeToApply)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RadioReboot)
        Me.Controls.Add(Me.RadioLogOff)
        Me.Controls.Add(Me.RadioShut)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmdToSend)
        Me.MaximumSize = New System.Drawing.Size(480, 325)
        Me.MinimumSize = New System.Drawing.Size(480, 325)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdToSend As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioShut As RadioButton
    Friend WithEvents RadioLogOff As RadioButton
    Friend WithEvents RadioReboot As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimeToApply As TextBox
    Friend WithEvents HH As TextBox
    Friend WithEvents MM As TextBox
    Friend WithEvents SS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdtosenddefault As TextBox
    Friend WithEvents TrayShutDownPlan As NotifyIcon
End Class
