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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sauce_id = New System.Windows.Forms.TextBox()
        Me.viewSauce = New System.Windows.Forms.Button()
        Me.roulette = New System.Windows.Forms.Button()
        Me.browsers = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.incogEnable = New System.Windows.Forms.CheckBox()
        Me.bookmarks = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.open = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "nHentai Sauce Viewer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sauce_id)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 51)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sauce ID"
        '
        'sauce_id
        '
        Me.sauce_id.Location = New System.Drawing.Point(6, 21)
        Me.sauce_id.MaxLength = 6
        Me.sauce_id.Name = "sauce_id"
        Me.sauce_id.Size = New System.Drawing.Size(120, 22)
        Me.sauce_id.TabIndex = 1
        '
        'viewSauce
        '
        Me.viewSauce.Enabled = False
        Me.viewSauce.Location = New System.Drawing.Point(20, 123)
        Me.viewSauce.Name = "viewSauce"
        Me.viewSauce.Size = New System.Drawing.Size(75, 23)
        Me.viewSauce.TabIndex = 2
        Me.viewSauce.Text = "View sauce"
        Me.viewSauce.UseVisualStyleBackColor = True
        '
        'roulette
        '
        Me.roulette.Location = New System.Drawing.Point(20, 152)
        Me.roulette.Name = "roulette"
        Me.roulette.Size = New System.Drawing.Size(75, 23)
        Me.roulette.TabIndex = 3
        Me.roulette.Text = "ROULETTE"
        Me.roulette.UseVisualStyleBackColor = True
        '
        'browsers
        '
        Me.browsers.FormattingEnabled = True
        Me.browsers.Items.AddRange(New Object() {"Chrome", "Firefox", "Opera", "Vivaldi", "Internet Explorer"})
        Me.browsers.Location = New System.Drawing.Point(6, 19)
        Me.browsers.Name = "browsers"
        Me.browsers.Size = New System.Drawing.Size(120, 24)
        Me.browsers.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.browsers)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(152, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(132, 51)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Browser"
        '
        'incogEnable
        '
        Me.incogEnable.AutoSize = True
        Me.incogEnable.Checked = True
        Me.incogEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.incogEnable.Location = New System.Drawing.Point(24, 185)
        Me.incogEnable.Name = "incogEnable"
        Me.incogEnable.Size = New System.Drawing.Size(70, 17)
        Me.incogEnable.TabIndex = 5
        Me.incogEnable.Text = "Incognito"
        Me.incogEnable.UseVisualStyleBackColor = True
        '
        'bookmarks
        '
        Me.bookmarks.FormattingEnabled = True
        Me.bookmarks.ItemHeight = 16
        Me.bookmarks.Location = New System.Drawing.Point(6, 21)
        Me.bookmarks.Name = "bookmarks"
        Me.bookmarks.Size = New System.Drawing.Size(159, 84)
        Me.bookmarks.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.open)
        Me.GroupBox3.Controls.Add(Me.delete)
        Me.GroupBox3.Controls.Add(Me.save)
        Me.GroupBox3.Controls.Add(Me.bookmarks)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox3.Location = New System.Drawing.Point(112, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(172, 137)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bookmarks"
        '
        'open
        '
        Me.open.Enabled = False
        Me.open.Location = New System.Drawing.Point(115, 108)
        Me.open.Name = "open"
        Me.open.Size = New System.Drawing.Size(50, 23)
        Me.open.TabIndex = 9
        Me.open.Text = "Open"
        Me.open.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Enabled = False
        Me.delete.Location = New System.Drawing.Point(57, 108)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(56, 23)
        Me.delete.TabIndex = 8
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Enabled = False
        Me.save.Location = New System.Drawing.Point(6, 108)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(48, 23)
        Me.save.TabIndex = 7
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 260)
        Me.Controls.Add(Me.incogEnable)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.roulette)
        Me.Controls.Add(Me.viewSauce)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "nHentai Sauce Viewer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents sauce_id As TextBox
    Friend WithEvents viewSauce As Button
    Friend WithEvents roulette As Button
    Friend WithEvents browsers As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents incogEnable As CheckBox
    Friend WithEvents bookmarks As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents open As Button
    Friend WithEvents delete As Button
    Friend WithEvents save As Button
End Class
