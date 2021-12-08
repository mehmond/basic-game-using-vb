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
        Me.lb_start = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lb_score = New System.Windows.Forms.Label()
        Me.lb_score2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pb_ground = New System.Windows.Forms.PictureBox()
        Me.pb_air = New System.Windows.Forms.PictureBox()
        Me.pb_bird = New System.Windows.Forms.PictureBox()
        Me.pb_bg = New System.Windows.Forms.PictureBox()
        CType(Me.pb_ground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_air, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_start
        '
        Me.lb_start.AutoSize = True
        Me.lb_start.BackColor = System.Drawing.Color.Transparent
        Me.lb_start.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_start.Location = New System.Drawing.Point(71, 170)
        Me.lb_start.Name = "lb_start"
        Me.lb_start.Size = New System.Drawing.Size(269, 34)
        Me.lb_start.TabIndex = 4
        Me.lb_start.Text = "Hit Space to Start"
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'lb_score
        '
        Me.lb_score.AutoSize = True
        Me.lb_score.BackColor = System.Drawing.Color.Wheat
        Me.lb_score.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_score.Location = New System.Drawing.Point(8, 3)
        Me.lb_score.Name = "lb_score"
        Me.lb_score.Size = New System.Drawing.Size(39, 14)
        Me.lb_score.TabIndex = 5
        Me.lb_score.Text = "Score : "
        Me.lb_score.Visible = False
        '
        'lb_score2
        '
        Me.lb_score2.AutoSize = True
        Me.lb_score2.BackColor = System.Drawing.Color.Wheat
        Me.lb_score2.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_score2.Location = New System.Drawing.Point(47, 3)
        Me.lb_score2.Name = "lb_score2"
        Me.lb_score2.Size = New System.Drawing.Size(15, 14)
        Me.lb_score2.TabIndex = 6
        Me.lb_score2.Text = " 0"
        Me.lb_score2.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 40
        '
        'pb_ground
        '
        Me.pb_ground.Image = Global.FlapFlap.My.Resources.Resources.ground
        Me.pb_ground.Location = New System.Drawing.Point(-2, 372)
        Me.pb_ground.Name = "pb_ground"
        Me.pb_ground.Size = New System.Drawing.Size(434, 44)
        Me.pb_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ground.TabIndex = 3
        Me.pb_ground.TabStop = False
        '
        'pb_air
        '
        Me.pb_air.Image = Global.FlapFlap.My.Resources.Resources.aor
        Me.pb_air.Location = New System.Drawing.Point(-2, 0)
        Me.pb_air.Name = "pb_air"
        Me.pb_air.Size = New System.Drawing.Size(434, 22)
        Me.pb_air.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_air.TabIndex = 2
        Me.pb_air.TabStop = False
        '
        'pb_bird
        '
        Me.pb_bird.BackColor = System.Drawing.Color.Transparent
        Me.pb_bird.Image = Global.FlapFlap.My.Resources.Resources.bird1
        Me.pb_bird.Location = New System.Drawing.Point(12, 187)
        Me.pb_bird.Name = "pb_bird"
        Me.pb_bird.Size = New System.Drawing.Size(31, 20)
        Me.pb_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_bird.TabIndex = 1
        Me.pb_bird.TabStop = False
        '
        'pb_bg
        '
        Me.pb_bg.Image = Global.FlapFlap.My.Resources.Resources.bg
        Me.pb_bg.Location = New System.Drawing.Point(-2, 0)
        Me.pb_bg.Name = "pb_bg"
        Me.pb_bg.Size = New System.Drawing.Size(434, 416)
        Me.pb_bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_bg.TabIndex = 0
        Me.pb_bg.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 417)
        Me.Controls.Add(Me.lb_score2)
        Me.Controls.Add(Me.lb_score)
        Me.Controls.Add(Me.lb_start)
        Me.Controls.Add(Me.pb_ground)
        Me.Controls.Add(Me.pb_air)
        Me.Controls.Add(Me.pb_bird)
        Me.Controls.Add(Me.pb_bg)
        Me.Name = "Form1"
        Me.Text = "FlapFlap"
        CType(Me.pb_ground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_air, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_bg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_bg As System.Windows.Forms.PictureBox
    Friend WithEvents pb_bird As System.Windows.Forms.PictureBox
    Friend WithEvents pb_air As System.Windows.Forms.PictureBox
    Friend WithEvents pb_ground As System.Windows.Forms.PictureBox
    Friend WithEvents lb_start As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lb_score2 As System.Windows.Forms.Label
    Friend WithEvents lb_score As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
