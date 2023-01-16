<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label_res = New System.Windows.Forms.Label()
        Me.Label_sinal = New System.Windows.Forms.Label()
        Me.Label_hist = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Roundbutton10 = New Calculator.roundbutton()
        Me.Roundbutton_igual = New Calculator.roundbutton()
        Me.Roundbutton11 = New Calculator.roundbutton()
        Me.Roundbutton0 = New Calculator.roundbutton()
        Me.Roundbutton_add = New Calculator.roundbutton()
        Me.Roundbutton3 = New Calculator.roundbutton()
        Me.Roundbutton2 = New Calculator.roundbutton()
        Me.Roundbutton1 = New Calculator.roundbutton()
        Me.Roundbutton_menos = New Calculator.roundbutton()
        Me.Roundbutton6 = New Calculator.roundbutton()
        Me.Roundbutton5 = New Calculator.roundbutton()
        Me.Roundbutton4 = New Calculator.roundbutton()
        Me.Roundbutton_x = New Calculator.roundbutton()
        Me.Roundbutton9 = New Calculator.roundbutton()
        Me.Roundbutton8 = New Calculator.roundbutton()
        Me.Roundbutton7 = New Calculator.roundbutton()
        Me.Roundbutton_dividir = New Calculator.roundbutton()
        Me.Roundbutton_mod = New Calculator.roundbutton()
        Me.Roundbutton_div = New Calculator.roundbutton()
        Me.Roundbutton_ac = New Calculator.roundbutton()
        Me.PictureBox_close = New System.Windows.Forms.PictureBox()
        Me.PictureBox_menu = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_conver = New System.Windows.Forms.Label()
        CType(Me.PictureBox_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_res
        '
        Me.Label_res.BackColor = System.Drawing.Color.Transparent
        Me.Label_res.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_res.ForeColor = System.Drawing.Color.White
        Me.Label_res.Location = New System.Drawing.Point(49, 101)
        Me.Label_res.Name = "Label_res"
        Me.Label_res.Size = New System.Drawing.Size(159, 63)
        Me.Label_res.TabIndex = 17
        Me.Label_res.Text = " 0"
        Me.Label_res.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label_sinal
        '
        Me.Label_sinal.BackColor = System.Drawing.Color.Transparent
        Me.Label_sinal.Font = New System.Drawing.Font("Yu Gothic UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_sinal.ForeColor = System.Drawing.Color.White
        Me.Label_sinal.Location = New System.Drawing.Point(12, 101)
        Me.Label_sinal.Name = "Label_sinal"
        Me.Label_sinal.Size = New System.Drawing.Size(40, 69)
        Me.Label_sinal.TabIndex = 37
        Me.Label_sinal.Text = " "
        '
        'Label_hist
        '
        Me.Label_hist.BackColor = System.Drawing.Color.Black
        Me.Label_hist.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_hist.ForeColor = System.Drawing.Color.Silver
        Me.Label_hist.Location = New System.Drawing.Point(75, 38)
        Me.Label_hist.Name = "Label_hist"
        Me.Label_hist.Size = New System.Drawing.Size(156, 39)
        Me.Label_hist.TabIndex = 39
        Me.Label_hist.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(228, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(228, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 24)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "X"
        Me.Label2.Visible = False
        '
        'Roundbutton10
        '
        Me.Roundbutton10.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton10.FlatAppearance.BorderSize = 0
        Me.Roundbutton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton10.ForeColor = System.Drawing.Color.White
        Me.Roundbutton10.Location = New System.Drawing.Point(136, 414)
        Me.Roundbutton10.Name = "Roundbutton10"
        Me.Roundbutton10.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton10.TabIndex = 43
        Me.Roundbutton10.Text = " x²"
        Me.Roundbutton10.UseVisualStyleBackColor = False
        '
        'Roundbutton_igual
        '
        Me.Roundbutton_igual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Roundbutton_igual.FlatAppearance.BorderSize = 0
        Me.Roundbutton_igual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Roundbutton_igual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Roundbutton_igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton_igual.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton_igual.ForeColor = System.Drawing.Color.White
        Me.Roundbutton_igual.Location = New System.Drawing.Point(197, 415)
        Me.Roundbutton_igual.Name = "Roundbutton_igual"
        Me.Roundbutton_igual.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton_igual.TabIndex = 36
        Me.Roundbutton_igual.Text = "="
        Me.Roundbutton_igual.UseVisualStyleBackColor = False
        '
        'Roundbutton11
        '
        Me.Roundbutton11.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton11.FlatAppearance.BorderSize = 0
        Me.Roundbutton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton11.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton11.ForeColor = System.Drawing.Color.White
        Me.Roundbutton11.Location = New System.Drawing.Point(75, 415)
        Me.Roundbutton11.Name = "Roundbutton11"
        Me.Roundbutton11.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton11.TabIndex = 35
        Me.Roundbutton11.Text = "."
        Me.Roundbutton11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Roundbutton11.UseVisualStyleBackColor = False
        '
        'Roundbutton0
        '
        Me.Roundbutton0.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton0.FlatAppearance.BorderSize = 0
        Me.Roundbutton0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton0.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton0.ForeColor = System.Drawing.Color.White
        Me.Roundbutton0.Location = New System.Drawing.Point(14, 414)
        Me.Roundbutton0.Name = "Roundbutton0"
        Me.Roundbutton0.Size = New System.Drawing.Size(54, 53)
        Me.Roundbutton0.TabIndex = 34
        Me.Roundbutton0.Text = "0"
        Me.Roundbutton0.UseVisualStyleBackColor = False
        '
        'Roundbutton_add
        '
        Me.Roundbutton_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Roundbutton_add.FlatAppearance.BorderSize = 0
        Me.Roundbutton_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Roundbutton_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Roundbutton_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton_add.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton_add.ForeColor = System.Drawing.Color.White
        Me.Roundbutton_add.Location = New System.Drawing.Point(197, 356)
        Me.Roundbutton_add.Name = "Roundbutton_add"
        Me.Roundbutton_add.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton_add.TabIndex = 33
        Me.Roundbutton_add.Text = "+"
        Me.Roundbutton_add.UseVisualStyleBackColor = False
        '
        'Roundbutton3
        '
        Me.Roundbutton3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton3.FlatAppearance.BorderSize = 0
        Me.Roundbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton3.ForeColor = System.Drawing.Color.White
        Me.Roundbutton3.Location = New System.Drawing.Point(136, 356)
        Me.Roundbutton3.Name = "Roundbutton3"
        Me.Roundbutton3.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton3.TabIndex = 32
        Me.Roundbutton3.Text = "3"
        Me.Roundbutton3.UseVisualStyleBackColor = False
        '
        'Roundbutton2
        '
        Me.Roundbutton2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton2.FlatAppearance.BorderSize = 0
        Me.Roundbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton2.ForeColor = System.Drawing.Color.White
        Me.Roundbutton2.Location = New System.Drawing.Point(75, 356)
        Me.Roundbutton2.Name = "Roundbutton2"
        Me.Roundbutton2.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton2.TabIndex = 31
        Me.Roundbutton2.Text = "2"
        Me.Roundbutton2.UseVisualStyleBackColor = False
        '
        'Roundbutton1
        '
        Me.Roundbutton1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton1.FlatAppearance.BorderSize = 0
        Me.Roundbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton1.ForeColor = System.Drawing.Color.White
        Me.Roundbutton1.Location = New System.Drawing.Point(14, 356)
        Me.Roundbutton1.Name = "Roundbutton1"
        Me.Roundbutton1.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton1.TabIndex = 30
        Me.Roundbutton1.Text = "1"
        Me.Roundbutton1.UseVisualStyleBackColor = False
        '
        'Roundbutton_menos
        '
        Me.Roundbutton_menos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Roundbutton_menos.FlatAppearance.BorderSize = 0
        Me.Roundbutton_menos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Roundbutton_menos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Roundbutton_menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton_menos.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton_menos.ForeColor = System.Drawing.Color.White
        Me.Roundbutton_menos.Location = New System.Drawing.Point(197, 298)
        Me.Roundbutton_menos.Name = "Roundbutton_menos"
        Me.Roundbutton_menos.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton_menos.TabIndex = 29
        Me.Roundbutton_menos.Text = "-"
        Me.Roundbutton_menos.UseVisualStyleBackColor = False
        '
        'Roundbutton6
        '
        Me.Roundbutton6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton6.FlatAppearance.BorderSize = 0
        Me.Roundbutton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton6.ForeColor = System.Drawing.Color.White
        Me.Roundbutton6.Location = New System.Drawing.Point(136, 298)
        Me.Roundbutton6.Name = "Roundbutton6"
        Me.Roundbutton6.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton6.TabIndex = 28
        Me.Roundbutton6.Text = "6"
        Me.Roundbutton6.UseVisualStyleBackColor = False
        '
        'Roundbutton5
        '
        Me.Roundbutton5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton5.FlatAppearance.BorderSize = 0
        Me.Roundbutton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton5.ForeColor = System.Drawing.Color.White
        Me.Roundbutton5.Location = New System.Drawing.Point(75, 298)
        Me.Roundbutton5.Name = "Roundbutton5"
        Me.Roundbutton5.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton5.TabIndex = 27
        Me.Roundbutton5.Text = "5"
        Me.Roundbutton5.UseVisualStyleBackColor = False
        '
        'Roundbutton4
        '
        Me.Roundbutton4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton4.FlatAppearance.BorderSize = 0
        Me.Roundbutton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton4.ForeColor = System.Drawing.Color.White
        Me.Roundbutton4.Location = New System.Drawing.Point(14, 298)
        Me.Roundbutton4.Name = "Roundbutton4"
        Me.Roundbutton4.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton4.TabIndex = 26
        Me.Roundbutton4.Text = "4"
        Me.Roundbutton4.UseVisualStyleBackColor = False
        '
        'Roundbutton_x
        '
        Me.Roundbutton_x.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Roundbutton_x.FlatAppearance.BorderSize = 0
        Me.Roundbutton_x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Roundbutton_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Roundbutton_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton_x.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton_x.ForeColor = System.Drawing.Color.White
        Me.Roundbutton_x.Location = New System.Drawing.Point(197, 240)
        Me.Roundbutton_x.Name = "Roundbutton_x"
        Me.Roundbutton_x.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton_x.TabIndex = 25
        Me.Roundbutton_x.Text = "x"
        Me.Roundbutton_x.UseVisualStyleBackColor = False
        '
        'Roundbutton9
        '
        Me.Roundbutton9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton9.FlatAppearance.BorderSize = 0
        Me.Roundbutton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton9.ForeColor = System.Drawing.Color.White
        Me.Roundbutton9.Location = New System.Drawing.Point(136, 240)
        Me.Roundbutton9.Name = "Roundbutton9"
        Me.Roundbutton9.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton9.TabIndex = 24
        Me.Roundbutton9.Text = "9"
        Me.Roundbutton9.UseVisualStyleBackColor = False
        '
        'Roundbutton8
        '
        Me.Roundbutton8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton8.FlatAppearance.BorderSize = 0
        Me.Roundbutton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton8.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton8.ForeColor = System.Drawing.Color.White
        Me.Roundbutton8.Location = New System.Drawing.Point(75, 240)
        Me.Roundbutton8.Name = "Roundbutton8"
        Me.Roundbutton8.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton8.TabIndex = 23
        Me.Roundbutton8.Text = "8"
        Me.Roundbutton8.UseVisualStyleBackColor = False
        '
        'Roundbutton7
        '
        Me.Roundbutton7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Roundbutton7.FlatAppearance.BorderSize = 0
        Me.Roundbutton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton7.ForeColor = System.Drawing.Color.White
        Me.Roundbutton7.Location = New System.Drawing.Point(15, 240)
        Me.Roundbutton7.Name = "Roundbutton7"
        Me.Roundbutton7.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton7.TabIndex = 22
        Me.Roundbutton7.Text = "7"
        Me.Roundbutton7.UseVisualStyleBackColor = False
        '
        'Roundbutton_dividir
        '
        Me.Roundbutton_dividir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Roundbutton_dividir.FlatAppearance.BorderSize = 0
        Me.Roundbutton_dividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton_dividir.Font = New System.Drawing.Font("Gadugi", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton_dividir.ForeColor = System.Drawing.Color.White
        Me.Roundbutton_dividir.Location = New System.Drawing.Point(197, 182)
        Me.Roundbutton_dividir.Name = "Roundbutton_dividir"
        Me.Roundbutton_dividir.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton_dividir.TabIndex = 21
        Me.Roundbutton_dividir.Text = "÷"
        Me.Roundbutton_dividir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Roundbutton_dividir.UseVisualStyleBackColor = False
        '
        'Roundbutton_mod
        '
        Me.Roundbutton_mod.BackColor = System.Drawing.Color.LightGray
        Me.Roundbutton_mod.FlatAppearance.BorderSize = 0
        Me.Roundbutton_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton_mod.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton_mod.Location = New System.Drawing.Point(136, 182)
        Me.Roundbutton_mod.Name = "Roundbutton_mod"
        Me.Roundbutton_mod.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton_mod.TabIndex = 20
        Me.Roundbutton_mod.Text = "√x"
        Me.Roundbutton_mod.UseVisualStyleBackColor = False
        '
        'Roundbutton_div
        '
        Me.Roundbutton_div.BackColor = System.Drawing.Color.LightGray
        Me.Roundbutton_div.FlatAppearance.BorderSize = 0
        Me.Roundbutton_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton_div.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton_div.Location = New System.Drawing.Point(75, 182)
        Me.Roundbutton_div.Name = "Roundbutton_div"
        Me.Roundbutton_div.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton_div.TabIndex = 19
        Me.Roundbutton_div.Text = "+/-"
        Me.Roundbutton_div.UseVisualStyleBackColor = False
        '
        'Roundbutton_ac
        '
        Me.Roundbutton_ac.BackColor = System.Drawing.Color.LightGray
        Me.Roundbutton_ac.FlatAppearance.BorderSize = 0
        Me.Roundbutton_ac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Roundbutton_ac.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roundbutton_ac.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Roundbutton_ac.Location = New System.Drawing.Point(14, 182)
        Me.Roundbutton_ac.Name = "Roundbutton_ac"
        Me.Roundbutton_ac.Size = New System.Drawing.Size(53, 53)
        Me.Roundbutton_ac.TabIndex = 18
        Me.Roundbutton_ac.Text = "AC"
        Me.Roundbutton_ac.UseVisualStyleBackColor = False
        '
        'PictureBox_close
        '
        Me.PictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_close.Image = Global.Calculator.My.Resources.Resources.close
        Me.PictureBox_close.Location = New System.Drawing.Point(17, 16)
        Me.PictureBox_close.Name = "PictureBox_close"
        Me.PictureBox_close.Size = New System.Drawing.Size(25, 23)
        Me.PictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_close.TabIndex = 51
        Me.PictureBox_close.TabStop = False
        Me.PictureBox_close.Visible = False
        '
        'PictureBox_menu
        '
        Me.PictureBox_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_menu.Image = Global.Calculator.My.Resources.Resources.menu__1_
        Me.PictureBox_menu.Location = New System.Drawing.Point(15, 9)
        Me.PictureBox_menu.Name = "PictureBox_menu"
        Me.PictureBox_menu.Size = New System.Drawing.Size(30, 36)
        Me.PictureBox_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_menu.TabIndex = 50
        Me.PictureBox_menu.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Calculator.My.Resources.Resources.toggle_button
        Me.PictureBox4.Location = New System.Drawing.Point(158, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 49
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Calculator.My.Resources.Resources.brightness_and_contrast1
        Me.PictureBox3.Location = New System.Drawing.Point(196, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 47
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Calculator.My.Resources.Resources.on_button
        Me.PictureBox2.Location = New System.Drawing.Point(161, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Calculator.My.Resources.Resources.clear1
        Me.PictureBox1.Location = New System.Drawing.Point(197, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label_conver
        '
        Me.Label_conver.AutoSize = True
        Me.Label_conver.BackColor = System.Drawing.Color.Black
        Me.Label_conver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_conver.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_conver.ForeColor = System.Drawing.Color.White
        Me.Label_conver.Location = New System.Drawing.Point(13, 48)
        Me.Label_conver.Name = "Label_conver"
        Me.Label_conver.Size = New System.Drawing.Size(99, 18)
        Me.Label_conver.TabIndex = 52
        Me.Label_conver.Text = " Conversões"
        Me.Label_conver.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(265, 481)
        Me.Controls.Add(Me.Label_conver)
        Me.Controls.Add(Me.PictureBox_menu)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Roundbutton10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label_sinal)
        Me.Controls.Add(Me.Roundbutton_igual)
        Me.Controls.Add(Me.Roundbutton11)
        Me.Controls.Add(Me.Roundbutton0)
        Me.Controls.Add(Me.Roundbutton_add)
        Me.Controls.Add(Me.Roundbutton3)
        Me.Controls.Add(Me.Roundbutton2)
        Me.Controls.Add(Me.Roundbutton1)
        Me.Controls.Add(Me.Roundbutton_menos)
        Me.Controls.Add(Me.Roundbutton6)
        Me.Controls.Add(Me.Roundbutton5)
        Me.Controls.Add(Me.Roundbutton4)
        Me.Controls.Add(Me.Roundbutton_x)
        Me.Controls.Add(Me.Roundbutton9)
        Me.Controls.Add(Me.Roundbutton8)
        Me.Controls.Add(Me.Roundbutton7)
        Me.Controls.Add(Me.Roundbutton_dividir)
        Me.Controls.Add(Me.Roundbutton_mod)
        Me.Controls.Add(Me.Roundbutton_div)
        Me.Controls.Add(Me.Roundbutton_ac)
        Me.Controls.Add(Me.Label_res)
        Me.Controls.Add(Me.Label_hist)
        Me.Controls.Add(Me.PictureBox_close)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        CType(Me.PictureBox_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_res As Label
    Friend WithEvents Roundbutton_ac As roundbutton
    Friend WithEvents Roundbutton_div As roundbutton
    Friend WithEvents Roundbutton_mod As roundbutton
    Friend WithEvents Roundbutton_dividir As roundbutton
    Friend WithEvents Roundbutton_x As roundbutton
    Friend WithEvents Roundbutton9 As roundbutton
    Friend WithEvents Roundbutton8 As roundbutton
    Friend WithEvents Roundbutton7 As roundbutton
    Friend WithEvents Roundbutton_menos As roundbutton
    Friend WithEvents Roundbutton6 As roundbutton
    Friend WithEvents Roundbutton5 As roundbutton
    Friend WithEvents Roundbutton4 As roundbutton
    Friend WithEvents Roundbutton_add As roundbutton
    Friend WithEvents Roundbutton3 As roundbutton
    Friend WithEvents Roundbutton2 As roundbutton
    Friend WithEvents Roundbutton1 As roundbutton
    Friend WithEvents Roundbutton_igual As roundbutton
    Friend WithEvents Roundbutton11 As roundbutton
    Friend WithEvents Roundbutton0 As roundbutton
    Friend WithEvents Label_sinal As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Roundbutton10 As roundbutton
    Friend WithEvents Label_hist As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox_menu As PictureBox
    Friend WithEvents PictureBox_close As PictureBox
    Friend WithEvents Label_conver As Label
End Class
