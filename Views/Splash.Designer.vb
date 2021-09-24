<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.ProgressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressState = New System.Windows.Forms.Label()
        Me.LoaderState = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressTimer
        '
        Me.ProgressTimer.Interval = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee Management System"
        '
        'ProgressState
        '
        Me.ProgressState.AutoSize = True
        Me.ProgressState.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ProgressState.Location = New System.Drawing.Point(170, 97)
        Me.ProgressState.Name = "ProgressState"
        Me.ProgressState.Size = New System.Drawing.Size(37, 22)
        Me.ProgressState.TabIndex = 2
        Me.ProgressState.Text = "0%"
        '
        'LoaderState
        '
        Me.LoaderState.AutoSize = True
        Me.LoaderState.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoaderState.ForeColor = System.Drawing.Color.Silver
        Me.LoaderState.Location = New System.Drawing.Point(152, 134)
        Me.LoaderState.Name = "LoaderState"
        Me.LoaderState.Size = New System.Drawing.Size(90, 19)
        Me.LoaderState.TabIndex = 3
        Me.LoaderState.Text = "Loading....."
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 240)
        Me.Controls.Add(Me.LoaderState)
        Me.Controls.Add(Me.ProgressState)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressTimer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressState As Label
    Friend WithEvents LoaderState As Label
End Class
