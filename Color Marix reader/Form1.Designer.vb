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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picturebox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SaveMatrix = New System.Windows.Forms.Button()
        Me.LoadMatrix = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenMatrixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveColorizedImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.resetMatrix = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cameralabel1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(426, 237)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'picturebox2
        '
        Me.picturebox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picturebox2.Location = New System.Drawing.Point(444, 31)
        Me.picturebox2.Name = "picturebox2"
        Me.picturebox2.Size = New System.Drawing.Size(471, 235)
        Me.picturebox2.TabIndex = 1
        Me.picturebox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Location = New System.Drawing.Point(12, 323)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 110)
        Me.Panel1.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(-12, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(213, 28)
        Me.ComboBox1.TabIndex = 3
        '
        'SaveMatrix
        '
        Me.SaveMatrix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaveMatrix.Location = New System.Drawing.Point(431, 12)
        Me.SaveMatrix.Name = "SaveMatrix"
        Me.SaveMatrix.Size = New System.Drawing.Size(94, 29)
        Me.SaveMatrix.TabIndex = 4
        Me.SaveMatrix.Text = "Save"
        Me.SaveMatrix.UseVisualStyleBackColor = True
        '
        'LoadMatrix
        '
        Me.LoadMatrix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadMatrix.Location = New System.Drawing.Point(331, 12)
        Me.LoadMatrix.Name = "LoadMatrix"
        Me.LoadMatrix.Size = New System.Drawing.Size(94, 29)
        Me.LoadMatrix.TabIndex = 5
        Me.LoadMatrix.Text = "Load"
        Me.LoadMatrix.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(927, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenImageToolStripMenuItem, Me.OpenMatrixToolStripMenuItem, Me.CloseImageToolStripMenuItem, Me.ExitToolStripMenuItem, Me.SaveColorizedImageToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "F&ile"
        '
        'OpenImageToolStripMenuItem
        '
        Me.OpenImageToolStripMenuItem.Name = "OpenImageToolStripMenuItem"
        Me.OpenImageToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.OpenImageToolStripMenuItem.Text = "Open Image"
        '
        'OpenMatrixToolStripMenuItem
        '
        Me.OpenMatrixToolStripMenuItem.Name = "OpenMatrixToolStripMenuItem"
        Me.OpenMatrixToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.OpenMatrixToolStripMenuItem.Text = "Open Matrix"
        '
        'CloseImageToolStripMenuItem
        '
        Me.CloseImageToolStripMenuItem.Enabled = False
        Me.CloseImageToolStripMenuItem.Name = "CloseImageToolStripMenuItem"
        Me.CloseImageToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.CloseImageToolStripMenuItem.Text = "Close Image"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.ExitToolStripMenuItem.Text = "Ex&it"
        '
        'SaveColorizedImageToolStripMenuItem
        '
        Me.SaveColorizedImageToolStripMenuItem.Name = "SaveColorizedImageToolStripMenuItem"
        Me.SaveColorizedImageToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.SaveColorizedImageToolStripMenuItem.Text = "S&ave Colorized Image"
        '
        'resetMatrix
        '
        Me.resetMatrix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.resetMatrix.Location = New System.Drawing.Point(231, 12)
        Me.resetMatrix.Name = "resetMatrix"
        Me.resetMatrix.Size = New System.Drawing.Size(94, 29)
        Me.resetMatrix.TabIndex = 4
        Me.resetMatrix.Text = "Reset"
        Me.resetMatrix.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.cameralabel1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.SaveMatrix)
        Me.Panel2.Controls.Add(Me.LoadMatrix)
        Me.Panel2.Controls.Add(Me.resetMatrix)
        Me.Panel2.Location = New System.Drawing.Point(12, 272)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(903, 44)
        Me.Panel2.TabIndex = 7
        '
        'cameralabel1
        '
        Me.cameralabel1.AutoSize = True
        Me.cameralabel1.Location = New System.Drawing.Point(867, 16)
        Me.cameralabel1.Name = "cameralabel1"
        Me.cameralabel1.Size = New System.Drawing.Size(0, 20)
        Me.cameralabel1.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(716, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 29)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Save Camera Roll"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(540, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "New Camera Roll"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 453)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.picturebox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picturebox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SaveMatrix As Button
    Friend WithEvents LoadMatrix As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenMatrixToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents resetMatrix As Button
    Friend WithEvents SaveColorizedImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cameralabel1 As Label
End Class
