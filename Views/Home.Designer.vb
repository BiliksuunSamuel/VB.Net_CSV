<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Emailtxt = New System.Windows.Forms.TextBox()
        Me.Phonetxt = New System.Windows.Forms.TextBox()
        Me.Usernametxt = New System.Windows.Forms.TextBox()
        Me.ClearInfobtn = New System.Windows.Forms.Button()
        Me.SaveInfobtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Exitbtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.Employees = New System.Windows.Forms.DataGridView()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ExitAppbtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Employees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Emailtxt)
        Me.Panel1.Controls.Add(Me.Phonetxt)
        Me.Panel1.Controls.Add(Me.Usernametxt)
        Me.Panel1.Location = New System.Drawing.Point(23, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(405, 139)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phone Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Full Name"
        '
        'Emailtxt
        '
        Me.Emailtxt.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emailtxt.Location = New System.Drawing.Point(126, 98)
        Me.Emailtxt.Name = "Emailtxt"
        Me.Emailtxt.Size = New System.Drawing.Size(258, 30)
        Me.Emailtxt.TabIndex = 2
        '
        'Phonetxt
        '
        Me.Phonetxt.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phonetxt.Location = New System.Drawing.Point(126, 57)
        Me.Phonetxt.Name = "Phonetxt"
        Me.Phonetxt.Size = New System.Drawing.Size(258, 30)
        Me.Phonetxt.TabIndex = 1
        '
        'Usernametxt
        '
        Me.Usernametxt.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernametxt.Location = New System.Drawing.Point(126, 14)
        Me.Usernametxt.Name = "Usernametxt"
        Me.Usernametxt.Size = New System.Drawing.Size(258, 30)
        Me.Usernametxt.TabIndex = 0
        '
        'ClearInfobtn
        '
        Me.ClearInfobtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearInfobtn.Location = New System.Drawing.Point(448, 173)
        Me.ClearInfobtn.Name = "ClearInfobtn"
        Me.ClearInfobtn.Size = New System.Drawing.Size(110, 23)
        Me.ClearInfobtn.TabIndex = 7
        Me.ClearInfobtn.Text = "Clear"
        Me.ClearInfobtn.UseVisualStyleBackColor = True
        '
        'SaveInfobtn
        '
        Me.SaveInfobtn.Location = New System.Drawing.Point(448, 139)
        Me.SaveInfobtn.Name = "SaveInfobtn"
        Me.SaveInfobtn.Size = New System.Drawing.Size(206, 23)
        Me.SaveInfobtn.TabIndex = 6
        Me.SaveInfobtn.Text = "Save"
        Me.SaveInfobtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditToolStripMenuItem, Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.MenuItem_Exitbtn})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem2.Text = "Reset"
        '
        'MenuItem_Exitbtn
        '
        Me.MenuItem_Exitbtn.Name = "MenuItem_Exitbtn"
        Me.MenuItem_Exitbtn.Size = New System.Drawing.Size(102, 22)
        Me.MenuItem_Exitbtn.Text = "Exit"
        '
        'Employees
        '
        Me.Employees.AllowUserToAddRows = False
        Me.Employees.AllowUserToDeleteRows = False
        Me.Employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Employees.BackgroundColor = System.Drawing.Color.White
        Me.Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Employees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserName, Me.PhoneNumber, Me.EmailAddress})
        Me.Employees.Location = New System.Drawing.Point(23, 202)
        Me.Employees.Name = "Employees"
        Me.Employees.ReadOnly = True
        Me.Employees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Employees.Size = New System.Drawing.Size(649, 289)
        Me.Employees.TabIndex = 2
        '
        'UserName
        '
        Me.UserName.HeaderText = "User Name"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'PhoneNumber
        '
        Me.PhoneNumber.HeaderText = "Phone Number"
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.ReadOnly = True
        '
        'EmailAddress
        '
        Me.EmailAddress.HeaderText = "Email Address"
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Old English Text MT", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(434, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 79)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E.M.S"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(301, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "EMPLOYEES MANAGEMENT SYSTEM"
        '
        'ExitAppbtn
        '
        Me.ExitAppbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitAppbtn.Location = New System.Drawing.Point(562, 173)
        Me.ExitAppbtn.Name = "ExitAppbtn"
        Me.ExitAppbtn.Size = New System.Drawing.Size(92, 23)
        Me.ExitAppbtn.TabIndex = 9
        Me.ExitAppbtn.Text = "Exit"
        Me.ExitAppbtn.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AcceptButton = Me.SaveInfobtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.ClearInfobtn
        Me.ClientSize = New System.Drawing.Size(693, 503)
        Me.Controls.Add(Me.ExitAppbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ClearInfobtn)
        Me.Controls.Add(Me.SaveInfobtn)
        Me.Controls.Add(Me.Employees)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Employees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Emailtxt As TextBox
    Friend WithEvents Phonetxt As TextBox
    Friend WithEvents Usernametxt As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClearInfobtn As Button
    Friend WithEvents SaveInfobtn As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MenuItem_Exitbtn As ToolStripMenuItem
    Friend WithEvents Employees As DataGridView
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddress As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents ExitAppbtn As Button
End Class
