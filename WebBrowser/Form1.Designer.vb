<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Web = New Microsoft.Web.WebView2.WinForms.WebView2()
        PanelTop = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        BackButton = New Button()
        TextBox1 = New TextBox()
        SearchButton = New Button()
        RefreshButton = New Button()
        ForwardButton = New Button()
        SettingsButton = New Button()
        CType(Web, ComponentModel.ISupportInitialize).BeginInit()
        PanelTop.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Web
        ' 
        Web.AllowExternalDrop = True
        Web.CreationProperties = Nothing
        Web.DefaultBackgroundColor = Color.White
        Web.Dock = DockStyle.Bottom
        Web.Location = New Point(0, 0)
        Web.Name = "Web"
        Web.Size = New Size(853, 450)
        Web.TabIndex = 0
        Web.ZoomFactor = 1R
        ' 
        ' PanelTop
        ' 
        PanelTop.Controls.Add(TableLayoutPanel1)
        PanelTop.Dock = DockStyle.Top
        PanelTop.Location = New Point(0, 0)
        PanelTop.Name = "PanelTop"
        PanelTop.Size = New Size(853, 35)
        PanelTop.TabIndex = 6
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(BackButton, 0, 0)
        TableLayoutPanel1.Controls.Add(TextBox1, 5, 0)
        TableLayoutPanel1.Controls.Add(SearchButton, 3, 0)
        TableLayoutPanel1.Controls.Add(RefreshButton, 2, 0)
        TableLayoutPanel1.Controls.Add(ForwardButton, 1, 0)
        TableLayoutPanel1.Controls.Add(SettingsButton, 4, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(853, 35)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' BackButton
        ' 
        BackButton.Dock = DockStyle.Fill
        BackButton.Location = New Point(3, 3)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(28, 29)
        BackButton.TabIndex = 3
        BackButton.Text = "<-"
        BackButton.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(313, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(626, 23)
        TextBox1.TabIndex = 1
        ' 
        ' SearchButton
        ' 
        SearchButton.Dock = DockStyle.Fill
        SearchButton.Location = New Point(133, 3)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(85, 29)
        SearchButton.TabIndex = 2
        SearchButton.Text = "Search"
        SearchButton.UseVisualStyleBackColor = True
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Dock = DockStyle.Fill
        RefreshButton.Location = New Point(73, 3)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(54, 29)
        RefreshButton.TabIndex = 5
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' ForwardButton
        ' 
        ForwardButton.Dock = DockStyle.Fill
        ForwardButton.Location = New Point(37, 3)
        ForwardButton.Name = "ForwardButton"
        ForwardButton.Size = New Size(30, 29)
        ForwardButton.TabIndex = 4
        ForwardButton.Text = "->"
        ForwardButton.UseVisualStyleBackColor = True
        ' 
        ' SettingsButton
        ' 
        SettingsButton.Location = New Point(224, 3)
        SettingsButton.Name = "SettingsButton"
        SettingsButton.Size = New Size(83, 29)
        SettingsButton.TabIndex = 6
        SettingsButton.Text = "Settings"
        SettingsButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(853, 450)
        Controls.Add(PanelTop)
        Controls.Add(Web)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Web Browser"
        CType(Web, ComponentModel.ISupportInitialize).EndInit()
        PanelTop.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Web As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents PanelTop As Panel
    Friend WithEvents SearchButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RefreshButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ForwardButton As Button
    Friend WithEvents SettingsButton As Button

End Class
