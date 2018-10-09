<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashCreen
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
        Me.components = New System.ComponentModel.Container()
        Me.SplashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.progy = New System.Windows.Forms.ProgressBar()
        Me.lblWait = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SplashTimer
        '
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Wide Latin", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(185, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(415, 36)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Fees Collection "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(204, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 28)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Proudly sponsored by Memory"
        '
        'progy
        '
        Me.progy.BackColor = System.Drawing.Color.Red
        Me.progy.Location = New System.Drawing.Point(-5, 152)
        Me.progy.Name = "progy"
        Me.progy.Size = New System.Drawing.Size(816, 10)
        Me.progy.TabIndex = 42
        Me.progy.Visible = False
        '
        'lblWait
        '
        Me.lblWait.AutoSize = True
        Me.lblWait.BackColor = System.Drawing.Color.Transparent
        Me.lblWait.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.ForeColor = System.Drawing.Color.White
        Me.lblWait.Location = New System.Drawing.Point(0, 119)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(173, 32)
        Me.lblWait.TabIndex = 43
        Me.lblWait.Text = "Loading.........."
        Me.lblWait.Visible = False
        '
        'SplashCreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(806, 162)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.progy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashCreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashCreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplashTimer As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents progy As ProgressBar
    Friend WithEvents lblWait As Label
End Class
