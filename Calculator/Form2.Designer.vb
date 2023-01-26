<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_tit_moeda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_valor_moeda = New System.Windows.Forms.TextBox()
        Me.ComboBox_moeda1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_moeda2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_comprimento2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox_comprimento1 = New System.Windows.Forms.ComboBox()
        Me.TextBox_valor_comprimento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_tit_comprimento = New System.Windows.Forms.Label()
        Me.ComboBox_bytes2 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox_bytes1 = New System.Windows.Forms.ComboBox()
        Me.TextBox_valor_bytes = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_tit_bytes = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button_moeda = New System.Windows.Forms.Button()
        Me.Button_comprimento = New System.Windows.Forms.Button()
        Me.Button_bytes = New System.Windows.Forms.Button()
        Me.PictureBox_disabled = New System.Windows.Forms.PictureBox()
        Me.PictureBox_sun = New System.Windows.Forms.PictureBox()
        Me.PictureBox_enabled = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        CType(Me.PictureBox_disabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_sun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_enabled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(539, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 24)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "X"
        '
        'Label_tit_moeda
        '
        Me.Label_tit_moeda.AutoSize = True
        Me.Label_tit_moeda.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tit_moeda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_tit_moeda.Location = New System.Drawing.Point(29, 51)
        Me.Label_tit_moeda.Name = "Label_tit_moeda"
        Me.Label_tit_moeda.Size = New System.Drawing.Size(60, 19)
        Me.Label_tit_moeda.TabIndex = 46
        Me.Label_tit_moeda.Text = "Moeda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(30, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Quero converter"
        '
        'TextBox_valor_moeda
        '
        Me.TextBox_valor_moeda.Location = New System.Drawing.Point(33, 107)
        Me.TextBox_valor_moeda.Name = "TextBox_valor_moeda"
        Me.TextBox_valor_moeda.Size = New System.Drawing.Size(115, 20)
        Me.TextBox_valor_moeda.TabIndex = 48
        Me.TextBox_valor_moeda.Text = "0"
        '
        'ComboBox_moeda1
        '
        Me.ComboBox_moeda1.FormattingEnabled = True
        Me.ComboBox_moeda1.Items.AddRange(New Object() {"Euro (EUR)", "Libra (GBP)", "Dollar (USD)"})
        Me.ComboBox_moeda1.Location = New System.Drawing.Point(33, 143)
        Me.ComboBox_moeda1.Name = "ComboBox_moeda1"
        Me.ComboBox_moeda1.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox_moeda1.TabIndex = 49
        Me.ComboBox_moeda1.Text = "Clique para mais"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Para"
        '
        'ComboBox_moeda2
        '
        Me.ComboBox_moeda2.FormattingEnabled = True
        Me.ComboBox_moeda2.Items.AddRange(New Object() {"Euro (EUR)", "Libra(GBP)", "Dollar(USD)"})
        Me.ComboBox_moeda2.Location = New System.Drawing.Point(33, 206)
        Me.ComboBox_moeda2.Name = "ComboBox_moeda2"
        Me.ComboBox_moeda2.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox_moeda2.TabIndex = 51
        Me.ComboBox_moeda2.Text = "Clique para mais"
        '
        'ComboBox_comprimento2
        '
        Me.ComboBox_comprimento2.FormattingEnabled = True
        Me.ComboBox_comprimento2.Items.AddRange(New Object() {"milimetro (MM)", "Centimetro (CM)", "Decimetro (DM)", "Metro (M)", "Quilometro (KM)"})
        Me.ComboBox_comprimento2.Location = New System.Drawing.Point(216, 206)
        Me.ComboBox_comprimento2.Name = "ComboBox_comprimento2"
        Me.ComboBox_comprimento2.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox_comprimento2.TabIndex = 57
        Me.ComboBox_comprimento2.Text = "Clique para mais"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(213, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Para"
        '
        'ComboBox_comprimento1
        '
        Me.ComboBox_comprimento1.FormattingEnabled = True
        Me.ComboBox_comprimento1.Items.AddRange(New Object() {"milimetro (MM)", "Centimetro (CM)", "Decimetro (DM)", "Metro (M)", "Quilometro (KM)"})
        Me.ComboBox_comprimento1.Location = New System.Drawing.Point(216, 143)
        Me.ComboBox_comprimento1.Name = "ComboBox_comprimento1"
        Me.ComboBox_comprimento1.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox_comprimento1.TabIndex = 55
        Me.ComboBox_comprimento1.Text = "Clique para mais"
        '
        'TextBox_valor_comprimento
        '
        Me.TextBox_valor_comprimento.Location = New System.Drawing.Point(216, 107)
        Me.TextBox_valor_comprimento.Name = "TextBox_valor_comprimento"
        Me.TextBox_valor_comprimento.Size = New System.Drawing.Size(115, 20)
        Me.TextBox_valor_comprimento.TabIndex = 54
        Me.TextBox_valor_comprimento.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(213, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Quero converter"
        '
        'Label_tit_comprimento
        '
        Me.Label_tit_comprimento.AutoSize = True
        Me.Label_tit_comprimento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tit_comprimento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_tit_comprimento.Location = New System.Drawing.Point(212, 51)
        Me.Label_tit_comprimento.Name = "Label_tit_comprimento"
        Me.Label_tit_comprimento.Size = New System.Drawing.Size(113, 19)
        Me.Label_tit_comprimento.TabIndex = 52
        Me.Label_tit_comprimento.Text = "Comprimento"
        '
        'ComboBox_bytes2
        '
        Me.ComboBox_bytes2.FormattingEnabled = True
        Me.ComboBox_bytes2.Items.AddRange(New Object() {"Byte(B)", "Kilobyte(KB)", "Megabyte(MB)", "Gigabyte(GB)", "Terabyte(TB)"})
        Me.ComboBox_bytes2.Location = New System.Drawing.Point(407, 206)
        Me.ComboBox_bytes2.Name = "ComboBox_bytes2"
        Me.ComboBox_bytes2.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox_bytes2.TabIndex = 63
        Me.ComboBox_bytes2.Text = "Clique para mais"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(404, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 16)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Para"
        '
        'ComboBox_bytes1
        '
        Me.ComboBox_bytes1.FormattingEnabled = True
        Me.ComboBox_bytes1.Items.AddRange(New Object() {"Byte (B)", "Kilobyte (KB)", "Megabyte (MB)", "Gigabyte (GB)", "Terabyte (TB)"})
        Me.ComboBox_bytes1.Location = New System.Drawing.Point(407, 143)
        Me.ComboBox_bytes1.Name = "ComboBox_bytes1"
        Me.ComboBox_bytes1.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox_bytes1.TabIndex = 61
        Me.ComboBox_bytes1.Text = "Clique para mais"
        '
        'TextBox_valor_bytes
        '
        Me.TextBox_valor_bytes.Location = New System.Drawing.Point(407, 107)
        Me.TextBox_valor_bytes.Name = "TextBox_valor_bytes"
        Me.TextBox_valor_bytes.Size = New System.Drawing.Size(115, 20)
        Me.TextBox_valor_bytes.TabIndex = 60
        Me.TextBox_valor_bytes.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(404, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 16)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Quero converter"
        '
        'Label_tit_bytes
        '
        Me.Label_tit_bytes.AutoSize = True
        Me.Label_tit_bytes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tit_bytes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_tit_bytes.Location = New System.Drawing.Point(403, 51)
        Me.Label_tit_bytes.Name = "Label_tit_bytes"
        Me.Label_tit_bytes.Size = New System.Drawing.Size(53, 19)
        Me.Label_tit_bytes.TabIndex = 58
        Me.Label_tit_bytes.Text = "Bytes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(48, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 16)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "0"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(213, 272)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 16)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(404, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 16)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "0"
        '
        'Button_moeda
        '
        Me.Button_moeda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_moeda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_moeda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_moeda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_moeda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_moeda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_moeda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_moeda.Location = New System.Drawing.Point(51, 240)
        Me.Button_moeda.Name = "Button_moeda"
        Me.Button_moeda.Size = New System.Drawing.Size(75, 23)
        Me.Button_moeda.TabIndex = 67
        Me.Button_moeda.Text = "Converter"
        Me.Button_moeda.UseVisualStyleBackColor = False
        '
        'Button_comprimento
        '
        Me.Button_comprimento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_comprimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_comprimento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_comprimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_comprimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_comprimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_comprimento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_comprimento.Location = New System.Drawing.Point(234, 240)
        Me.Button_comprimento.Name = "Button_comprimento"
        Me.Button_comprimento.Size = New System.Drawing.Size(75, 23)
        Me.Button_comprimento.TabIndex = 68
        Me.Button_comprimento.Text = "Converter"
        Me.Button_comprimento.UseVisualStyleBackColor = False
        '
        'Button_bytes
        '
        Me.Button_bytes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_bytes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_bytes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_bytes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_bytes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_bytes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_bytes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bytes.Location = New System.Drawing.Point(424, 240)
        Me.Button_bytes.Name = "Button_bytes"
        Me.Button_bytes.Size = New System.Drawing.Size(75, 23)
        Me.Button_bytes.TabIndex = 69
        Me.Button_bytes.Text = "Converter"
        Me.Button_bytes.UseVisualStyleBackColor = False
        '
        'PictureBox_disabled
        '
        Me.PictureBox_disabled.Image = Global.Calculator.My.Resources.Resources.toggle_button
        Me.PictureBox_disabled.Location = New System.Drawing.Point(34, 3)
        Me.PictureBox_disabled.Name = "PictureBox_disabled"
        Me.PictureBox_disabled.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox_disabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_disabled.TabIndex = 102
        Me.PictureBox_disabled.TabStop = False
        Me.PictureBox_disabled.Visible = False
        '
        'PictureBox_sun
        '
        Me.PictureBox_sun.Image = Global.Calculator.My.Resources.Resources.brightness_and_contrast
        Me.PictureBox_sun.Location = New System.Drawing.Point(69, 7)
        Me.PictureBox_sun.Name = "PictureBox_sun"
        Me.PictureBox_sun.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox_sun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_sun.TabIndex = 101
        Me.PictureBox_sun.TabStop = False
        '
        'PictureBox_enabled
        '
        Me.PictureBox_enabled.Image = Global.Calculator.My.Resources.Resources.on_button
        Me.PictureBox_enabled.Location = New System.Drawing.Point(34, 6)
        Me.PictureBox_enabled.Name = "PictureBox_enabled"
        Me.PictureBox_enabled.Size = New System.Drawing.Size(33, 29)
        Me.PictureBox_enabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_enabled.TabIndex = 100
        Me.PictureBox_enabled.TabStop = False
        '
        'Label26
        '
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(539, 9)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 24)
        Me.Label26.TabIndex = 103
        Me.Label26.Text = "X"
        Me.Label26.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(597, 352)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.PictureBox_disabled)
        Me.Controls.Add(Me.PictureBox_sun)
        Me.Controls.Add(Me.PictureBox_enabled)
        Me.Controls.Add(Me.Button_bytes)
        Me.Controls.Add(Me.Button_comprimento)
        Me.Controls.Add(Me.Button_moeda)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox_bytes2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox_bytes1)
        Me.Controls.Add(Me.TextBox_valor_bytes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label_tit_bytes)
        Me.Controls.Add(Me.ComboBox_comprimento2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox_comprimento1)
        Me.Controls.Add(Me.TextBox_valor_comprimento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label_tit_comprimento)
        Me.Controls.Add(Me.ComboBox_moeda2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox_moeda1)
        Me.Controls.Add(Me.TextBox_valor_moeda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_tit_moeda)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversões"
        CType(Me.PictureBox_disabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_sun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_enabled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label_tit_moeda As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_valor_moeda As TextBox
    Friend WithEvents ComboBox_moeda1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_moeda2 As ComboBox
    Friend WithEvents ComboBox_comprimento2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox_comprimento1 As ComboBox
    Friend WithEvents TextBox_valor_comprimento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label_tit_comprimento As Label
    Friend WithEvents ComboBox_bytes2 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox_bytes1 As ComboBox
    Friend WithEvents TextBox_valor_bytes As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label_tit_bytes As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button_moeda As Button
    Friend WithEvents Button_comprimento As Button
    Friend WithEvents Button_bytes As Button
    Friend WithEvents PictureBox_disabled As PictureBox
    Friend WithEvents PictureBox_sun As PictureBox
    Friend WithEvents PictureBox_enabled As PictureBox
    Friend WithEvents Label26 As Label
End Class
