Public Class Form1
    Dim cDef As Color
    Dim txt As String
    Sub egg(ByVal s As String)
        txt = txt + s
        If txt.ToLower = "fart" Then
            MsgBox("No Fart In Computer! (C)", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Please!")
            txt = ""
        End If
       
    End Sub
    Sub updateInfo()
        systemLabel.Text = My.Computer.Info.OSFullName & " " & My.Computer.Info.OSPlatform & " (version: " & My.Computer.Info.OSVersion & ")"
        LangL.Text = My.Computer.Info.InstalledUICulture.DisplayName & " (" & My.Computer.Info.InstalledUICulture.EnglishName & ")"
        PhL.Text = My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 & " / " & My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024 & " MB"
        VML.Text = My.Computer.Info.TotalVirtualMemory / 1024 / 1024 & " / " & My.Computer.Info.AvailableVirtualMemory / 1024 / 1024 & " MB"
        Me.Text = My.User.Name
        If My.Computer.Clipboard.ContainsText Then
            ClipL.Text = My.Computer.Clipboard.GetText
            ClipL.ReadOnly = False

        Else
            ClipL.Text = " < nothing or not text >"
            ClipL.ReadOnly = True
        End If
        If My.Computer.Keyboard.AltKeyDown Then ALTL.BackColor = Color.LightGreen Else ALTL.BackColor = cDef
        If My.Computer.Keyboard.CtrlKeyDown Then CTRL.BackColor = Color.LightGreen Else CTRL.BackColor = cDef
        If My.Computer.Keyboard.ShiftKeyDown Then SHIFTL.BackColor = Color.LightGreen Else SHIFTL.BackColor = cDef
        If My.Computer.Keyboard.NumLock Then NUML.BackColor = Color.LightGreen Else NUML.BackColor = cDef
        If My.Computer.Keyboard.CapsLock Then CAPL.BackColor = Color.LightGreen Else CAPL.BackColor = cDef
        If My.Computer.Keyboard.ScrollLock Then SCROLL.BackColor = Color.LightGreen Else SCROLL.BackColor = cDef
        Me.Focus()
        ScrL.Text = "GMT: " & My.Computer.Clock.GmtTime & " / Local: " & My.Computer.Clock.LocalTime & " / TickCount: " & My.Computer.Clock.TickCount
        ComL.Text = "COM Port count: " & My.Computer.Ports.SerialPortNames.Count
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        updateInfo()
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        egg(e.KeyChar)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cDef = NUML.BackColor
        Dim temp As String
        For Each Disk As System.IO.DriveInfo In My.Computer.FileSystem.Drives

            If Disk.DriveType = IO.DriveType.Fixed Or Disk.DriveType = IO.DriveType.Network Or Disk.DriveType = IO.DriveType.Ram Then temp = temp & vbCrLf & vbCrLf & Disk.VolumeLabel & " / " & Disk.Name & " / " & Disk.DriveFormat & " / Space:" & CStr(Disk.TotalSize / 1024 / 1024) & "MB / Free: " & CStr(Disk.TotalFreeSpace / 1024 / 1024) & "MB / Available: " & CStr(Disk.AvailableFreeSpace / 1024 / 1024) & "MB"

        Next
        Me.Focus()
        DriveL.Text = temp
        updateInfo()
    End Sub

    

   
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ClipL.Width = Me.Width - ClipL.Left - 15
        DriveL.Width = Me.Width - DriveL.Left - 15
    End Sub

    Private Sub DriveL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DriveL.KeyPress
        egg(e.KeyChar)
    End Sub

    Private Sub DriveL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveL.TextChanged

    End Sub

    Private Sub ClipL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ClipL.KeyPress
        egg(e.KeyChar)
    End Sub

    Private Sub ClipL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClipL.TextChanged

    End Sub
End Class
