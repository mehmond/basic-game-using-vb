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
        Me.components = New System.ComponentModel.Container()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.DTGKO = New System.Windows.Forms.DataGridView()
        Me.tb_pname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pb_bird = New System.Windows.Forms.PictureBox()
        Me.tb_search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.DTGKO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_submit
        '
        Me.btn_submit.BackgroundImage = Global.FlapFlap.My.Resources.Resources.button
        Me.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_submit.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_submit.Location = New System.Drawing.Point(148, 264)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(111, 29)
        Me.btn_submit.TabIndex = 0
        Me.btn_submit.Text = "Register"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.BackgroundImage = Global.FlapFlap.My.Resources.Resources.button
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_search.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_search.Location = New System.Drawing.Point(149, 122)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(111, 29)
        Me.btn_search.TabIndex = 1
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'DTGKO
        '
        Me.DTGKO.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DTGKO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGKO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGKO.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DTGKO.Location = New System.Drawing.Point(90, 12)
        Me.DTGKO.Name = "DTGKO"
        Me.DTGKO.RowHeadersWidth = 31
        Me.DTGKO.Size = New System.Drawing.Size(231, 66)
        Me.DTGKO.TabIndex = 2
        '
        'tb_pname
        '
        Me.tb_pname.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tb_pname.Location = New System.Drawing.Point(100, 239)
        Me.tb_pname.Name = "tb_pname"
        Me.tb_pname.Size = New System.Drawing.Size(213, 20)
        Me.tb_pname.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Player's Name"
        '
        'btn_start
        '
        Me.btn_start.BackgroundImage = Global.FlapFlap.My.Resources.Resources.button
        Me.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_start.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_start.Location = New System.Drawing.Point(139, 320)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(128, 41)
        Me.btn_start.TabIndex = 5
        Me.btn_start.Text = "START"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60
        '
        'pb_bird
        '
        Me.pb_bird.BackColor = System.Drawing.Color.Transparent
        Me.pb_bird.Image = Global.FlapFlap.My.Resources.Resources.bird1
        Me.pb_bird.Location = New System.Drawing.Point(12, 198)
        Me.pb_bird.Name = "pb_bird"
        Me.pb_bird.Size = New System.Drawing.Size(45, 27)
        Me.pb_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_bird.TabIndex = 8
        Me.pb_bird.TabStop = False
        '
        'tb_search
        '
        Me.tb_search.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.tb_search.Location = New System.Drawing.Point(101, 99)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Size = New System.Drawing.Size(213, 20)
        Me.tb_search.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Search Player's Name"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 60
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.FlapFlap.My.Resources.Resources.cloud2
        Me.PictureBox1.Location = New System.Drawing.Point(281, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.FlapFlap.My.Resources.Resources.cloud3
        Me.PictureBox2.Location = New System.Drawing.Point(90, 146)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(116, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.FlapFlap.My.Resources.Resources.cloud1
        Me.PictureBox3.Location = New System.Drawing.Point(265, 264)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(116, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlapFlap.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(429, 417)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_search)
        Me.Controls.Add(Me.pb_bird)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_pname)
        Me.Controls.Add(Me.DTGKO)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_submit)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FlapFlap"
        CType(Me.DTGKO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents DTGKO As System.Windows.Forms.DataGridView
    Friend WithEvents tb_pname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pb_bird As System.Windows.Forms.PictureBox
    Friend WithEvents tb_search As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
