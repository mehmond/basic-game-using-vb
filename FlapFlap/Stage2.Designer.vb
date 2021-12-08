<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stage2
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lb_start = New System.Windows.Forms.Label()
        Me.lb_score2 = New System.Windows.Forms.Label()
        Me.lb_score = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.tm_gravity = New System.Windows.Forms.Timer(Me.components)
        Me.lb_objective = New System.Windows.Forms.Label()
        Me.tm_enemy = New System.Windows.Forms.Timer(Me.components)
        Me.pb_ground = New System.Windows.Forms.PictureBox()
        Me.pb_air = New System.Windows.Forms.PictureBox()
        Me.pb_bird = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pb_ground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_air, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'Timer2
        '
        Me.Timer2.Interval = 240
        '
        'lb_start
        '
        Me.lb_start.AutoSize = True
        Me.lb_start.BackColor = System.Drawing.Color.Transparent
        Me.lb_start.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_start.Location = New System.Drawing.Point(78, 144)
        Me.lb_start.Name = "lb_start"
        Me.lb_start.Size = New System.Drawing.Size(291, 48)
        Me.lb_start.TabIndex = 11
        Me.lb_start.Text = "          Hit Space to Start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press Enter to Start the Game"
        '
        'lb_score2
        '
        Me.lb_score2.AutoSize = True
        Me.lb_score2.BackColor = System.Drawing.Color.Wheat
        Me.lb_score2.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_score2.Location = New System.Drawing.Point(46, 3)
        Me.lb_score2.Name = "lb_score2"
        Me.lb_score2.Size = New System.Drawing.Size(15, 14)
        Me.lb_score2.TabIndex = 13
        Me.lb_score2.Text = " 0"
        Me.lb_score2.Visible = False
        '
        'lb_score
        '
        Me.lb_score.AutoSize = True
        Me.lb_score.BackColor = System.Drawing.Color.Wheat
        Me.lb_score.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_score.Location = New System.Drawing.Point(7, 3)
        Me.lb_score.Name = "lb_score"
        Me.lb_score.Size = New System.Drawing.Size(39, 14)
        Me.lb_score.TabIndex = 12
        Me.lb_score.Text = "Score : "
        Me.lb_score.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(46, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = " 0"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(7, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Kills"
        Me.Label2.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 20
        '
        'tm_gravity
        '
        Me.tm_gravity.Interval = 40
        '
        'lb_objective
        '
        Me.lb_objective.AutoSize = True
        Me.lb_objective.BackColor = System.Drawing.Color.Transparent
        Me.lb_objective.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_objective.ForeColor = System.Drawing.Color.Red
        Me.lb_objective.Location = New System.Drawing.Point(80, 68)
        Me.lb_objective.Name = "lb_objective"
        Me.lb_objective.Size = New System.Drawing.Size(264, 24)
        Me.lb_objective.TabIndex = 18
        Me.lb_objective.Text = "Objective : Kill 20 enemies"
        '
        'tm_enemy
        '
        Me.tm_enemy.Interval = 40
        '
        'pb_ground
        '
        Me.pb_ground.BackColor = System.Drawing.Color.Transparent
        Me.pb_ground.Location = New System.Drawing.Point(-3, 406)
        Me.pb_ground.Name = "pb_ground"
        Me.pb_ground.Size = New System.Drawing.Size(434, 10)
        Me.pb_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ground.TabIndex = 10
        Me.pb_ground.TabStop = False
        '
        'pb_air
        '
        Me.pb_air.BackColor = System.Drawing.Color.Transparent
        Me.pb_air.Location = New System.Drawing.Point(-3, 0)
        Me.pb_air.Name = "pb_air"
        Me.pb_air.Size = New System.Drawing.Size(434, 22)
        Me.pb_air.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_air.TabIndex = 9
        Me.pb_air.TabStop = False
        '
        'pb_bird
        '
        Me.pb_bird.BackColor = System.Drawing.Color.Transparent
        Me.pb_bird.Image = Global.FlapFlap.My.Resources.Resources.bird1
        Me.pb_bird.Location = New System.Drawing.Point(31, 158)
        Me.pb_bird.Name = "pb_bird"
        Me.pb_bird.Size = New System.Drawing.Size(31, 20)
        Me.pb_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_bird.TabIndex = 8
        Me.pb_bird.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.FlapFlap.My.Resources.Resources.stage2bg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(429, 417)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Stage2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(429, 417)
        Me.Controls.Add(Me.lb_objective)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb_start)
        Me.Controls.Add(Me.pb_ground)
        Me.Controls.Add(Me.pb_air)
        Me.Controls.Add(Me.pb_bird)
        Me.Controls.Add(Me.lb_score2)
        Me.Controls.Add(Me.lb_score)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Stage2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FlapFlap - Stage 2"
        CType(Me.pb_ground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_air, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lb_start As System.Windows.Forms.Label
    Friend WithEvents pb_ground As System.Windows.Forms.PictureBox
    Friend WithEvents pb_air As System.Windows.Forms.PictureBox
    Friend WithEvents pb_bird As System.Windows.Forms.PictureBox
    Friend WithEvents lb_score2 As System.Windows.Forms.Label
    Friend WithEvents lb_score As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tm_gravity As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lb_objective As System.Windows.Forms.Label
    Friend WithEvents tm_enemy As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
