<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stage3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stage3))
        Me.pb_bird = New System.Windows.Forms.PictureBox()
        Me.pb_boss = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lb_objectives = New System.Windows.Forms.Label()
        Me.lb_start = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.pb_ground = New System.Windows.Forms.PictureBox()
        Me.pb_air = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tm_attack = New System.Windows.Forms.Timer(Me.components)
        Me.tm_gravity = New System.Windows.Forms.Timer(Me.components)
        Me.tm_die = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pb_bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_boss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_ground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_air, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_bird
        '
        Me.pb_bird.BackColor = System.Drawing.Color.Transparent
        Me.pb_bird.Image = Global.FlapFlap.My.Resources.Resources.bird1
        Me.pb_bird.Location = New System.Drawing.Point(31, 206)
        Me.pb_bird.Name = "pb_bird"
        Me.pb_bird.Size = New System.Drawing.Size(31, 20)
        Me.pb_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_bird.TabIndex = 9
        Me.pb_bird.TabStop = False
        '
        'pb_boss
        '
        Me.pb_boss.BackColor = System.Drawing.Color.Transparent
        Me.pb_boss.Image = CType(resources.GetObject("pb_boss.Image"), System.Drawing.Image)
        Me.pb_boss.Location = New System.Drawing.Point(315, 33)
        Me.pb_boss.Name = "pb_boss"
        Me.pb_boss.Size = New System.Drawing.Size(100, 58)
        Me.pb_boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_boss.TabIndex = 10
        Me.pb_boss.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'Timer2
        '
        Me.Timer2.Interval = 150
        '
        'lb_objectives
        '
        Me.lb_objectives.AutoSize = True
        Me.lb_objectives.BackColor = System.Drawing.Color.Transparent
        Me.lb_objectives.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_objectives.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_objectives.Location = New System.Drawing.Point(125, 34)
        Me.lb_objectives.Name = "lb_objectives"
        Me.lb_objectives.Size = New System.Drawing.Size(190, 20)
        Me.lb_objectives.TabIndex = 11
        Me.lb_objectives.Text = "Objective: Kill the boss"
        '
        'lb_start
        '
        Me.lb_start.AutoSize = True
        Me.lb_start.BackColor = System.Drawing.Color.Transparent
        Me.lb_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_start.Location = New System.Drawing.Point(133, 54)
        Me.lb_start.Name = "lb_start"
        Me.lb_start.Size = New System.Drawing.Size(179, 60)
        Me.lb_start.TabIndex = 12
        Me.lb_start.Text = "Press enter to Start " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Space to Jump " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right arrow to Attack"
        '
        'Timer3
        '
        Me.Timer3.Interval = 150
        '
        'Timer4
        '
        Me.Timer4.Interval = 150
        '
        'Timer5
        '
        Me.Timer5.Interval = 150
        '
        'pb_ground
        '
        Me.pb_ground.BackColor = System.Drawing.Color.Transparent
        Me.pb_ground.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pb_ground.Image = Global.FlapFlap.My.Resources.Resources.firewall1
        Me.pb_ground.Location = New System.Drawing.Point(0, 328)
        Me.pb_ground.Name = "pb_ground"
        Me.pb_ground.Size = New System.Drawing.Size(429, 89)
        Me.pb_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ground.TabIndex = 14
        Me.pb_ground.TabStop = False
        '
        'pb_air
        '
        Me.pb_air.BackColor = System.Drawing.Color.Transparent
        Me.pb_air.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb_air.Location = New System.Drawing.Point(0, 0)
        Me.pb_air.Name = "pb_air"
        Me.pb_air.Size = New System.Drawing.Size(429, 19)
        Me.pb_air.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_air.TabIndex = 15
        Me.pb_air.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.FlapFlap.My.Resources.Resources.lava1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(429, 417)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'tm_attack
        '
        Me.tm_attack.Interval = 20
        '
        'tm_gravity
        '
        Me.tm_gravity.Interval = 40
        '
        'tm_die
        '
        Me.tm_die.Interval = 240
        '
        'Stage3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlapFlap.My.Resources.Resources.lava1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(429, 417)
        Me.Controls.Add(Me.pb_ground)
        Me.Controls.Add(Me.pb_boss)
        Me.Controls.Add(Me.pb_air)
        Me.Controls.Add(Me.lb_start)
        Me.Controls.Add(Me.lb_objectives)
        Me.Controls.Add(Me.pb_bird)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Stage3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stage 3 - FlapFlap"
        CType(Me.pb_bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_boss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_ground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_air, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents pb_bird As System.Windows.Forms.PictureBox
    Friend WithEvents pb_boss As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lb_objectives As System.Windows.Forms.Label
    Friend WithEvents lb_start As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents pb_ground As System.Windows.Forms.PictureBox
    Friend WithEvents pb_air As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tm_attack As System.Windows.Forms.Timer
    Friend WithEvents tm_gravity As System.Windows.Forms.Timer
    Friend WithEvents tm_die As System.Windows.Forms.Timer
End Class
