Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmdToSend.Text = cmdtosenddefault.Text
    End Sub
    Private Sub RadioShut_CheckedChanged(sender As Object, e As EventArgs) Handles RadioShut.CheckedChanged
        CheckButtons()
    End Sub
    Private Sub RadioLogOff_CheckedChanged(sender As Object, e As EventArgs) Handles RadioLogOff.CheckedChanged
        CheckButtons()
    End Sub
    Private Sub RadioReboot_CheckedChanged(sender As Object, e As EventArgs) Handles RadioReboot.CheckedChanged
        CheckButtons()
    End Sub


    Sub CheckButtons()
        If RadioShut.Checked = True Then
            CmdToSend.Text = Replace(cmdtosenddefault.Text, "-s", "-" & "s")
        ElseIf RadioLogOff.Checked = True Then
            CmdToSend.Text = Replace(cmdtosenddefault.Text, "-s", "-" & "l")
        ElseIf RadioReboot.Checked = True Then
            CmdToSend.Text = Replace(cmdtosenddefault.Text, "-s", "-" & "r")
        End If
        calculatetime()
    End Sub

    Sub calculatetime()
        'Check if ""
        If HH.Text = "" Then HH.Text = 0
        If MM.Text = "" Then MM.Text = 0
        If SS.Text = "" Then SS.Text = 0

        Dim TimeHH = HH.Text * 3600
        Dim TimeMM = MM.Text * 60
        Dim TimeSS = SS.Text
        TimeToApply.Text = (TimeHH + TimeMM + TimeSS).ToString
    End Sub
    Private Sub TimeToApply_TextChanged(sender As Object, e As EventArgs) Handles TimeToApply.TextChanged
        If TimeToApply.Text = 0 Or CmdToSend.Text = "" Then Exit Sub
        CmdToSend.Text = Replace(CmdToSend.Text, CmdToSend.Text.Substring(15), TimeToApply.Text)
    End Sub
    Private Sub HH_TextChanged(sender As Object, e As EventArgs) Handles HH.TextChanged
        If HH.Text = "" Then HH.Text = 0
        If Len(HH.Text) >= 2 Then HH.SelectAll()
        calculatetime()
    End Sub

    Private Sub MM_TextChanged(sender As Object, e As EventArgs) Handles MM.TextChanged
        If CInt(MM.Text) >= 60 Or MM.Text = "" Then
            MM.Text = 59
        End If
        If Len(MM.Text) >= 2 Then MM.SelectAll()
        calculatetime()
    End Sub

    Private Sub SS_TextChanged(sender As Object, e As EventArgs) Handles SS.TextChanged
        If CInt(SS.Text) >= 60 Or SS.Text = "" Then
            SS.Text = 59
        End If
        If Len(SS.Text) >= 2 Then SS.SelectAll()
        calculatetime()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("cmd", "/c " & CmdToSend.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("cmd", "/c shutdown -a")
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            TrayShutDownPlan.Visible = True
            TrayShutDownPlan.Icon = My.Resources.Image
            TrayShutDownPlan.BalloonTipIcon = ToolTipIcon.Info
            TrayShutDownPlan.BalloonTipTitle = "ShutDownPlan"
            TrayShutDownPlan.BalloonTipText = "ShutDownPlan is Minimized !"
            TrayShutDownPlan.ShowBalloonTip(30000)
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles TrayShutDownPlan.DoubleClick
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        TrayShutDownPlan.Visible = False
    End Sub

End Class
