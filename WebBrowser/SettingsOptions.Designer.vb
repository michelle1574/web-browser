<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsOptions
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
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        LinkLabel1 = New LinkLabel()
        OKButton = New Button()
        CancelButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 30)
        Label1.TabIndex = 0
        Label1.Text = "Settings"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(12, 67)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(122, 19)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Enable Dark mode"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(12, 89)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(112, 15)
        LinkLabel1.TabIndex = 2
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Issues, suggestions?"
        ' 
        ' OKButton
        ' 
        OKButton.Location = New Point(197, 128)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(75, 23)
        OKButton.TabIndex = 3
        OKButton.Text = "OK"
        OKButton.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(278, 128)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(75, 23)
        CancelButton.TabIndex = 4
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(365, 163)
        Controls.Add(CancelButton)
        Controls.Add(OKButton)
        Controls.Add(LinkLabel1)
        Controls.Add(CheckBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Settings"
        Text = "Settings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents OKButton As Button
    Friend WithEvents CancelButton As Button
End Class
