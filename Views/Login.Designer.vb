<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Phonetxt = New System.Windows.Forms.TextBox()
        Me.Passwordtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Phonetxt
        '
        Me.Phonetxt.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phonetxt.Location = New System.Drawing.Point(68, 61)
        Me.Phonetxt.Name = "Phonetxt"
        Me.Phonetxt.Size = New System.Drawing.Size(303, 32)
        Me.Phonetxt.TabIndex = 0
        Me.Phonetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Passwordtxt
        '
        Me.Passwordtxt.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passwordtxt.Location = New System.Drawing.Point(68, 125)
        Me.Passwordtxt.Name = "Passwordtxt"
        Me.Passwordtxt.Size = New System.Drawing.Size(303, 32)
        Me.Passwordtxt.TabIndex = 1
        Me.Passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Passwordtxt.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PhoneNumber"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Loginbtn
        '
        Me.Loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Loginbtn.FlatAppearance.BorderSize = 0
        Me.Loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.Loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Loginbtn.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbtn.ForeColor = System.Drawing.Color.White
        Me.Loginbtn.Location = New System.Drawing.Point(68, 173)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(179, 28)
        Me.Loginbtn.TabIndex = 4
        Me.Loginbtn.Text = "LOGIN"
        Me.Loginbtn.UseVisualStyleBackColor = False
        '
        'Exitbtn
        '
        Me.Exitbtn.FlatAppearance.BorderSize = 0
        Me.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Exitbtn.Location = New System.Drawing.Point(264, 173)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(107, 28)
        Me.Exitbtn.TabIndex = 5
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(77, 217)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(141, 18)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Don't have Account?"
        '
        'Login
        '
        Me.AcceptButton = Me.Loginbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Exitbtn
        Me.ClientSize = New System.Drawing.Size(450, 270)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Loginbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Passwordtxt)
        Me.Controls.Add(Me.Phonetxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Phonetxt As TextBox
    Friend WithEvents Passwordtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Loginbtn As Button
    Friend WithEvents Exitbtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
