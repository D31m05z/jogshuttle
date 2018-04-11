<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "CANOPUS JOG/SHUTTLE"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.MenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 48)
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.SetupToolStripMenuItem.Text = "設定画面"
        '
        'MenuItem1
        '
        Me.MenuItem1.Name = "MenuItem1"
        Me.MenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.MenuItem1.Text = "終了"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(547, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Canopus Jog/Shuttle Controller JD1 設定画面"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(572, 256)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 19)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(572, 281)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 19)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(572, 306)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 19)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(572, 331)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 19)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(572, 356)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 19)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(572, 121)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(100, 19)
        Me.TextBox6.TabIndex = 4
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(572, 146)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 19)
        Me.TextBox7.TabIndex = 4
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(572, 171)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(100, 19)
        Me.TextBox8.TabIndex = 4
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(572, 200)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(100, 19)
        Me.TextBox9.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(555, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "・"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(549, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "・・"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(543, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "・・・"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(537, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "・・・・"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(531, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 12)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "・・・・・"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(502, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 12)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "DECK/FILE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(537, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "＜＜"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(537, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "＞＞"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(500, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 12)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "CAP/UNDO"
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(387, 200)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(100, 19)
        Me.TextBox10.TabIndex = 14
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(387, 175)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(100, 19)
        Me.TextBox11.TabIndex = 15
        '
        'TextBox12
        '
        Me.TextBox12.Enabled = False
        Me.TextBox12.Location = New System.Drawing.Point(387, 150)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(100, 19)
        Me.TextBox12.TabIndex = 15
        '
        'TextBox13
        '
        Me.TextBox13.Enabled = False
        Me.TextBox13.Location = New System.Drawing.Point(387, 121)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(100, 19)
        Me.TextBox13.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(364, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 12)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = ">||"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(365, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 12)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "IN"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(353, 178)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 12)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "OUT"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(327, 203)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 12)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "ADD/DIV"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(406, 75)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 20)
        Me.ComboBox1.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(331, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 12)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "動作モード名"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(597, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "設定終了"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button3.Location = New System.Drawing.Point(12, 440)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "ドライバ停止"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox14
        '
        Me.TextBox14.Enabled = False
        Me.TextBox14.Location = New System.Drawing.Point(387, 281)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(100, 19)
        Me.TextBox14.TabIndex = 25
        '
        'TextBox15
        '
        Me.TextBox15.Enabled = False
        Me.TextBox15.Location = New System.Drawing.Point(387, 306)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(100, 19)
        Me.TextBox15.TabIndex = 26
        '
        'TextBox16
        '
        Me.TextBox16.Enabled = False
        Me.TextBox16.Location = New System.Drawing.Point(387, 331)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ReadOnly = True
        Me.TextBox16.Size = New System.Drawing.Size(100, 19)
        Me.TextBox16.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(332, 284)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 12)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "時計回り"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(320, 309)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 12)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "反時計回り"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(395, 256)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 12)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "ダイヤル設定"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(349, 334)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 12)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "ボタン"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(387, 353)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox2.TabIndex = 32
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(352, 359)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 12)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "感度"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(468, 418)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(95, 20)
        Me.ComboBox3.TabIndex = 34
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(468, 445)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(95, 20)
        Me.ComboBox4.TabIndex = 34
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(374, 421)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 12)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "[感度]変更ボタン"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(346, 451)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(116, 12)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "[動作モード]変更ボタン"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(349, 387)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(307, 12)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "※感度・動作モード変更に設定したボタンの設定は無視されます"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JogShuttle_Controller.My.Resources.Resources.JD1_IMAGE
        Me.PictureBox1.Location = New System.Drawing.Point(12, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 339)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(216, 439)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "設定ファイル表示"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(93, 439)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 23)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "バージョン情報"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(684, 475)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canopus JD1 設定画面"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
