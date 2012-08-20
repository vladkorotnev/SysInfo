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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.systemLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LangL = New System.Windows.Forms.Label()
        Me.PhLable = New System.Windows.Forms.Label()
        Me.PhL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VML = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClipL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NUML = New System.Windows.Forms.Label()
        Me.CAPL = New System.Windows.Forms.Label()
        Me.SCROLL = New System.Windows.Forms.Label()
        Me.SHIFTL = New System.Windows.Forms.Label()
        Me.ALTL = New System.Windows.Forms.Label()
        Me.CTRL = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ScrL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DriveL = New System.Windows.Forms.TextBox()
        Me.ComL = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System:"
        '
        'systemLabel
        '
        Me.systemLabel.AutoSize = True
        Me.systemLabel.Location = New System.Drawing.Point(63, 27)
        Me.systemLabel.Name = "systemLabel"
        Me.systemLabel.Size = New System.Drawing.Size(38, 12)
        Me.systemLabel.TabIndex = 1
        Me.systemLabel.Text = "Label2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Language:"
        '
        'LangL
        '
        Me.LangL.AutoSize = True
        Me.LangL.Location = New System.Drawing.Point(73, 53)
        Me.LangL.Name = "LangL"
        Me.LangL.Size = New System.Drawing.Size(38, 12)
        Me.LangL.TabIndex = 3
        Me.LangL.Text = "Label3"
        '
        'PhLable
        '
        Me.PhLable.AutoSize = True
        Me.PhLable.Location = New System.Drawing.Point(12, 77)
        Me.PhLable.Name = "PhLable"
        Me.PhLable.Size = New System.Drawing.Size(128, 12)
        Me.PhLable.TabIndex = 4
        Me.PhLable.Text = "Physical memory / free:"
        '
        'PhL
        '
        Me.PhL.AutoSize = True
        Me.PhL.Location = New System.Drawing.Point(146, 77)
        Me.PhL.Name = "PhL"
        Me.PhL.Size = New System.Drawing.Size(38, 12)
        Me.PhL.TabIndex = 5
        Me.PhL.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Virtual memory / free:"
        '
        'VML
        '
        Me.VML.AutoSize = True
        Me.VML.Location = New System.Drawing.Point(146, 103)
        Me.VML.Name = "VML"
        Me.VML.Size = New System.Drawing.Size(38, 12)
        Me.VML.TabIndex = 7
        Me.VML.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Clipboard:"
        '
        'ClipL
        '
        Me.ClipL.Location = New System.Drawing.Point(75, 124)
        Me.ClipL.Multiline = True
        Me.ClipL.Name = "ClipL"
        Me.ClipL.ReadOnly = True
        Me.ClipL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ClipL.Size = New System.Drawing.Size(359, 90)
        Me.ClipL.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Keys:"
        '
        'NUML
        '
        Me.NUML.AutoSize = True
        Me.NUML.Location = New System.Drawing.Point(75, 233)
        Me.NUML.Name = "NUML"
        Me.NUML.Size = New System.Drawing.Size(30, 12)
        Me.NUML.TabIndex = 11
        Me.NUML.Text = "NUM"
        '
        'CAPL
        '
        Me.CAPL.AutoSize = True
        Me.CAPL.Location = New System.Drawing.Point(111, 233)
        Me.CAPL.Name = "CAPL"
        Me.CAPL.Size = New System.Drawing.Size(35, 12)
        Me.CAPL.TabIndex = 12
        Me.CAPL.Text = "CAPS"
        '
        'SCROLL
        '
        Me.SCROLL.AutoSize = True
        Me.SCROLL.Location = New System.Drawing.Point(152, 233)
        Me.SCROLL.Name = "SCROLL"
        Me.SCROLL.Size = New System.Drawing.Size(48, 12)
        Me.SCROLL.TabIndex = 13
        Me.SCROLL.Text = "SCROLL"
        '
        'SHIFTL
        '
        Me.SHIFTL.AutoSize = True
        Me.SHIFTL.Location = New System.Drawing.Point(206, 233)
        Me.SHIFTL.Name = "SHIFTL"
        Me.SHIFTL.Size = New System.Drawing.Size(37, 12)
        Me.SHIFTL.TabIndex = 14
        Me.SHIFTL.Text = "SHIFT"
        '
        'ALTL
        '
        Me.ALTL.AutoSize = True
        Me.ALTL.Location = New System.Drawing.Point(246, 233)
        Me.ALTL.Name = "ALTL"
        Me.ALTL.Size = New System.Drawing.Size(26, 12)
        Me.ALTL.TabIndex = 15
        Me.ALTL.Text = "ALT"
        '
        'CTRL
        '
        Me.CTRL.AutoSize = True
        Me.CTRL.Location = New System.Drawing.Point(278, 233)
        Me.CTRL.Name = "CTRL"
        Me.CTRL.Size = New System.Drawing.Size(34, 12)
        Me.CTRL.TabIndex = 16
        Me.CTRL.Text = "CTRL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 12)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Clock:"
        '
        'ScrL
        '
        Me.ScrL.AutoSize = True
        Me.ScrL.Location = New System.Drawing.Point(56, 260)
        Me.ScrL.Name = "ScrL"
        Me.ScrL.Size = New System.Drawing.Size(38, 12)
        Me.ScrL.TabIndex = 18
        Me.ScrL.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 12)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Disks:"
        '
        'DriveL
        '
        Me.DriveL.Location = New System.Drawing.Point(77, 285)
        Me.DriveL.Multiline = True
        Me.DriveL.Name = "DriveL"
        Me.DriveL.ReadOnly = True
        Me.DriveL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DriveL.Size = New System.Drawing.Size(352, 75)
        Me.DriveL.TabIndex = 20
        '
        'ComL
        '
        Me.ComL.AutoSize = True
        Me.ComL.Location = New System.Drawing.Point(12, 374)
        Me.ComL.Name = "ComL"
        Me.ComL.Size = New System.Drawing.Size(91, 12)
        Me.ComL.TabIndex = 21
        Me.ComL.Text = "COM Port Count:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(98, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(214, 12)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "By vladkorotnev and TheOlegFilms, 2012"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 411)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComL)
        Me.Controls.Add(Me.DriveL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ScrL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CTRL)
        Me.Controls.Add(Me.ALTL)
        Me.Controls.Add(Me.SHIFTL)
        Me.Controls.Add(Me.SCROLL)
        Me.Controls.Add(Me.CAPL)
        Me.Controls.Add(Me.NUML)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ClipL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.VML)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PhL)
        Me.Controls.Add(Me.PhLable)
        Me.Controls.Add(Me.LangL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.systemLabel)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents systemLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LangL As System.Windows.Forms.Label
    Friend WithEvents PhLable As System.Windows.Forms.Label
    Friend WithEvents PhL As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VML As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClipL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NUML As System.Windows.Forms.Label
    Friend WithEvents CAPL As System.Windows.Forms.Label
    Friend WithEvents SCROLL As System.Windows.Forms.Label
    Friend WithEvents SHIFTL As System.Windows.Forms.Label
    Friend WithEvents ALTL As System.Windows.Forms.Label
    Friend WithEvents CTRL As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ScrL As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DriveL As System.Windows.Forms.TextBox
    Friend WithEvents ComL As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
