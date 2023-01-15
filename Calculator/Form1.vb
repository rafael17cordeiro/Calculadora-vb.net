
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim add, subs, dividir, vezes, igual, virgula As Integer
    Dim num As Decimal
    Dim elevado, raiz As Double


    Private Sub Roundbutton1_Click(sender As Object, e As EventArgs) Handles Roundbutton1.Click

        If Val(Label_res.Text) = 0 And virgula = 0 Then
            Label_res.Text = 1
        Else
            Label_res.Text &= 1
        End If
        'neste evento de click a label do resultado vai tomar o valor de 1 e vai escrever na tele o respetivo numero

    End Sub

    Private Sub Roundbutton2_Click(sender As Object, e As EventArgs) Handles Roundbutton2.Click
        'escreve o valor na tela do utilizador
        If Val(Label_res.Text) = 0 And virgula = 0 Then
            Label_res.Text = 2
        Else
            Label_res.Text &= 2
        End If
        'neste evento de click a label do resultado vai tomar o valor de 2 e vai escrever na tele o respetivo numero
    End Sub

    Private Sub Roundbutton3_Click(sender As Object, e As EventArgs) Handles Roundbutton3.Click
        'escreve o valor na tela do utilizador
        If Val(Label_res.Text) = 0 And virgula = 0 Then
            Label_res.Text = 3
        Else
            Label_res.Text &= 3
        End If
        'neste evento de click a label do resultado vai tomar o valor de 3 e vai escrever na tele o respetivo numero
    End Sub

    Private Sub Roundbutton4_Click(sender As Object, e As EventArgs) Handles Roundbutton4.Click
        'escreve o valor na tela do utilizador
        If Val(Label_res.Text) = 0 And virgula = 0 Then
            Label_res.Text = 4
        Else
            Label_res.Text &= 4
        End If
        'neste evento de click a label do resultado vai tomar o valor de 4 e vai escrever na tele o respetivo numero
    End Sub

    Private Sub Roundbutton5_Click(sender As Object, e As EventArgs) Handles Roundbutton5.Click
        'escreve o valor na tela do utilizador
        If Val(Label_res.Text) = 0 And virgula = 0 Then
            Label_res.Text = 5
        Else
            Label_res.Text &= 5
        End If
        'neste evento de click a label do resultado vai tomar o valor de 5 e vai escrever na tele o respetivo numero
    End Sub

    Private Sub Roundbutton6_Click(sender As Object, e As EventArgs) Handles Roundbutton6.Click
        'escreve o valor na tela do utilizador
        If Val(Label_res.Text) = 0 And virgula = 0 Then
            Label_res.Text = 6
        Else
            Label_res.Text &= 6
        End If
        'neste evento de click a label do resultado vai tomar o valor de 6 e vai escrever na tele o respetivo numero
    End Sub

    Private Sub Roundbutton7_Click(sender As Object, e As EventArgs) Handles Roundbutton7.Click
        'escreve o valor na tela do utilizador

        If Val(Label_res.Text) = 0 And virgula = 0 Then
            Label_res.Text = 7
        Else
            Label_res.Text &= 7
        End If
    End Sub

    Private Sub Roundbutton8_Click(sender As Object, e As EventArgs) Handles Roundbutton8.Click
        'escreve o valor na tela do utilizador
        If Val(Label_res.Text) = 0 And virgula = 0 Then
            Label_res.Text = 8
        Else
            Label_res.Text &= 8
        End If

        'neste evento de click a label do resultado vai tomar o valor de 8 e vai escrever na tele o respetivo numero
    End Sub

    Private Sub Roundbutton9_Click(sender As Object, e As EventArgs) Handles Roundbutton9.Click
        'escreve o valor na tela do utilizador
        If Val(Label_res.Text) = 0 And virgula = 0 Then
            Label_res.Text = 9
        Else
            Label_res.Text &= 9
        End If
        'neste evento de click a label do resultado vai tomar o valor de 9 e vai escrever na tele o respetivo numero
    End Sub

    Private Sub Roundbutton0_Click(sender As Object, e As EventArgs) Handles Roundbutton0.Click
        If Val(Label_res.Text) = 0 And virgula = 0 Then
            Label_res.Text = 0
        Else
            Label_res.Text &= 0
        End If
        'neste evento de click a label do resultado vai tomar o valor de 0 e vai escrever na tele o respetivo numero
    End Sub

    Private Sub Roundbutton_x_Click(sender As Object, e As EventArgs) Handles Roundbutton_x.Click
        'estas variaveis funcionam como um bollean ou seja qunado o utilizador clica no botao 
        'o conter vezes adiciona 1 ou seja se o if (vezes =1) faz a multiplicação, se os conters da subtraçao,multipicaçao,
        'divisao etc.. forem = ou superiores a 1 signfica que tem de fazer o calculo primeiro por isso na label hist faz o
        'calculo e so depois é que procede para a multiplicação
        igual = 0
        vezes += 1
        num = Label_res.Text
        If subs <> 1 And dividir <> 1 And add <> 1 Then
            If vezes = 1 Then
                Label_hist.Text = num & " x "
                Label_sinal.Text = "x"
                Label_res.Text = 0
            ElseIf vezes > 1 Then
                Label_hist.Text = Val(Label_hist.Text) + num & "x"
                Label_sinal.Text = "x"
                Label_res.Text = 0
            End If
        ElseIf subs >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) - num & "x"
            Label_sinal.Text = "x"
            Label_res.Text = 0
            subs = 0
        ElseIf dividir >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) / num & " x "
            Label_sinal.Text = "x"
            Label_res.Text = 0
            dividir = 0
        ElseIf add >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) * num & "x"
            Label_sinal.Text = "x"
            Label_res.Text = 0
            add = 0
        End If

        If Label_res.Text Mod 1 = 0 Then
            virgula = 0
        Else
            virgula = 1
        End If
    End Sub


    Private Sub Roundbutton_menos_Click(sender As Object, e As EventArgs) Handles Roundbutton_menos.Click
        'estas variaveis funcionam como um bollean ou seja qunado o utilizador clica no botao 
        'o conter subs adiciona 1 ou seja se o if (vezes =1) faz a multiplicação, se os conters da subtraçao,multipicaçao,
        'divisao etc.. forem = ou superiores a 1 signfica que tem de fazer o calculo primeiro por isso na label hist faz o
        'calculo e so depois é que procede para a subtração
        igual = 0
        subs += 1
        num = Label_res.Text
        If add <> 1 And dividir <> 1 And vezes <> 1 Then
            If subs = 1 Then
                Label_hist.Text = num & " - "
                Label_sinal.Text = "-"
                Label_res.Text = 0
            ElseIf subs > 1 Then
                Label_hist.Text = Val(Label_hist.Text) - num & "-"
                Label_sinal.Text = "-"
                Label_res.Text = 0
            End If
        ElseIf add >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) + num & "-"
            Label_sinal.Text = "-"
            Label_res.Text = 0
            add = 0
        ElseIf dividir >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) / num & " - "
            Label_sinal.Text = "-"
            Label_res.Text = 0
            dividir = 0
        ElseIf vezes >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) * num & " - "
            Label_sinal.Text = "-"
            Label_res.Text = 0
            vezes = 0
        End If

        If Label_res.Text Mod 1 = 0 Then
            virgula = 0
        Else
            virgula = 1
        End If
    End Sub

    Private Sub Roundbutton11_Click(sender As Object, e As EventArgs) Handles Roundbutton11.Click
        'basicamente verifica se o numero ja tem vigula , se virgula = 0 significa que nao tem então virgula=1 e a label fica com "."
        If virgula = 0 Then
            virgula = 1
            Label_res.Text &= "."
        End If
    End Sub

    Private Sub Roundbutton_dividir_Click(sender As Object, e As EventArgs) Handles Roundbutton_dividir.Click
        'estas variaveis funcionam como um bollean ou seja qunado o utilizador clica no botao 
        'o conter dividir adiciona 1 ou seja se o if (vezes =1) faz a multiplicação, se os conters da subtraçao,multipicaçao,
        'divisao etc.. forem = ou superiores a 1 signfica que tem de fazer o calculo primeiro por isso na label hist faz o
        'calculo e so depois é que procede para a divisão
        igual = 0
        dividir += 1
        num = Label_res.Text
        If subs <> 1 And add <> 1 And vezes <> 1 Then
            If dividir = 1 Then
                Label_hist.Text = Label_res.Text & " / "
                Label_sinal.Text = "/"
                Label_res.Text = 0
            ElseIf dividir > 1 Then
                Label_hist.Text = Val(Label_hist.Text) + num & " / "
                Label_sinal.Text = "/"
                Label_res.Text = 0
            End If
        ElseIf subs >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) - num & " / "
            Label_sinal.Text = "/"
            Label_res.Text = 0
            subs = 0
        ElseIf add >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) + num & " / "
            Label_sinal.Text = "/"
            Label_res.Text = 0
            add = 0
        ElseIf vezes >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) * num & " / "
            Label_sinal.Text = "/"
            Label_res.Text = 0
            vezes = 0
        End If

        If Label_res.Text Mod 1 = 0 Then
            virgula = 0
        Else
            virgula = 1
        End If
    End Sub

    Private Sub Roundbutton_igual_Click(sender As Object, e As EventArgs) Handles Roundbutton_igual.Click
        igual += 1
        num = Label_res.Text
        Label_sinal.Text = ""
        If add >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) & "+" & +num & "="
            Label_res.Text = Val(Label_hist.Text) + num
            add = 0
        ElseIf subs >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) & "-" & -num & "="
            Label_res.Text = Val(Label_hist.Text) - num
            subs = 0
        ElseIf dividir >= 1 Then
            If num <> 0 Then
                Label_hist.Text = Val(Label_hist.Text) / num & "="
                Label_res.Text = Val(Label_hist.Text)
                dividir = 0
            Else
                MsgBox("Nenhum numero pode ser divisivel por 0")
            End If
        ElseIf vezes >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) & "X" & -num & "="
            Label_res.Text = Val(Label_hist.Text) * num
            vezes = 0
        ElseIf add = 0 And subs = 0 And dividir = 0 And vezes = 0 Then
            Label_res.Text = num
            Label_hist.Text = num & " = "
        End If

        If Label_res.Text Mod 1 = 0 Then
            virgula = 0
        Else
            virgula = 1
        End If

    End Sub

    Private Sub Roundbutton_ac_Click(sender As Object, e As EventArgs) Handles Roundbutton_ac.Click
        ' apagam tudo deixando so o 0 para o utilizador saber onde vai ser exibido o valor
        add = 0
        subs = 0
        igual = 0
        virgula = 0
        Label_res.Text = 0
        Label_hist.Text = ""
        Label_sinal.Text = ""

    End Sub

    Private Sub Roundbutton_div_Click(sender As Object, e As EventArgs) Handles Roundbutton_div.Click
        Label_res.Text = Label_res.Text * -1
    End Sub

    Private borderForm As New Form

    Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath
        path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
        path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
        path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With Me

            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label_res_Click(sender As Object, e As EventArgs) Handles Label_res.Click
        If Label_res.Text = "" Then
            Label_res.Text = 0
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Dim form As New Form

    End Sub

    Private Sub ConversõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversõesToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click


        Roundbutton0.BackColor = Color.WhiteSmoke
        Roundbutton1.BackColor = Color.WhiteSmoke
        Roundbutton2.BackColor = Color.WhiteSmoke
        Roundbutton3.BackColor = Color.WhiteSmoke
        Roundbutton4.BackColor = Color.WhiteSmoke
        Roundbutton5.BackColor = Color.WhiteSmoke
        Roundbutton6.BackColor = Color.WhiteSmoke
        Roundbutton7.BackColor = Color.WhiteSmoke
        Roundbutton8.BackColor = Color.WhiteSmoke
        Roundbutton9.BackColor = Color.WhiteSmoke
        Roundbutton10.BackColor = Color.WhiteSmoke
        Roundbutton11.BackColor = Color.WhiteSmoke


        Roundbutton0.ForeColor = Color.Black
        Roundbutton1.ForeColor = Color.Black
        Roundbutton2.ForeColor = Color.Black
        Roundbutton3.ForeColor = Color.Black
        Roundbutton4.ForeColor = Color.Black
        Roundbutton5.ForeColor = Color.Black
        Roundbutton6.ForeColor = Color.Black
        Roundbutton7.ForeColor = Color.Black
        Roundbutton8.ForeColor = Color.Black
        Roundbutton9.ForeColor = Color.Black
        Roundbutton10.ForeColor = Color.Black
        Roundbutton11.ForeColor = Color.Black


        Roundbutton_ac.BackColor = Color.Silver
        Roundbutton_div.BackColor = Color.Silver
        Roundbutton_mod.BackColor = Color.Silver


        Me.BackColor = Color.White
        Label_res.ForeColor = Color.Black
        MenuStrip1.BackColor = Color.White
        MenuStrip1.ForeColor = Color.Black
        Label_hist.ForeColor = Color.Black
        Label_hist.BackColor = Color.White
        Roundbutton_dividir.ForeColor = Color.Black
        Roundbutton_x.ForeColor = Color.Black
        Roundbutton_menos.ForeColor = Color.Black
        Roundbutton_add.ForeColor = Color.Black
        Roundbutton_igual.ForeColor = Color.Black
        ConversõesToolStripMenuItem.BackColor = Color.White
        ConversõesToolStripMenuItem.ForeColor = Color.Black
        Label1.Visible = False
        Label2.Visible = True
        PictureBox4.Visible = True

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.BackColor = Color.Black
        Roundbutton0.BackColor = Color.DimGray
        Roundbutton1.BackColor = Color.DimGray
        Roundbutton2.BackColor = Color.DimGray
        Roundbutton3.BackColor = Color.DimGray
        Roundbutton4.BackColor = Color.DimGray
        Roundbutton5.BackColor = Color.DimGray
        Roundbutton6.BackColor = Color.DimGray
        Roundbutton7.BackColor = Color.DimGray
        Roundbutton8.BackColor = Color.DimGray
        Roundbutton9.BackColor = Color.DimGray
        Roundbutton10.BackColor = Color.DimGray
        Roundbutton11.BackColor = Color.DimGray


        Roundbutton0.ForeColor = Color.White
        Roundbutton1.ForeColor = Color.White
        Roundbutton2.ForeColor = Color.White
        Roundbutton3.ForeColor = Color.White
        Roundbutton4.ForeColor = Color.White
        Roundbutton5.ForeColor = Color.White
        Roundbutton6.ForeColor = Color.White
        Roundbutton7.ForeColor = Color.White
        Roundbutton8.ForeColor = Color.White
        Roundbutton9.ForeColor = Color.White
        Roundbutton10.ForeColor = Color.White
        Roundbutton11.ForeColor = Color.White

        Label_res.ForeColor = Color.White
        MenuStrip1.BackColor = Color.Black
        MenuStrip1.ForeColor = Color.White
        Label_hist.ForeColor = Color.White
        Label_hist.BackColor = Color.Black
        Roundbutton_dividir.ForeColor = Color.White
        Roundbutton_x.ForeColor = Color.White
        Roundbutton_menos.ForeColor = Color.White
        Roundbutton_add.ForeColor = Color.White
        Roundbutton_igual.ForeColor = Color.White
        ConversõesToolStripMenuItem.BackColor = Color.Black
        ConversõesToolStripMenuItem.ForeColor = Color.White
        Label1.Visible = True
        Label2.Visible = False
        PictureBox4.Visible = False
    End Sub

    Private Sub Roundbutton12_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Roundbutton10_Click(sender As Object, e As EventArgs) Handles Roundbutton10.Click
        elevado = Label_res.Text
        Label_res.Text = elevado * elevado

        If Label_res.Text <> 0 Then
            If Label_res.Text <> "∞" Then
                Label_hist.Text = Label_res.Text
            Else
                Label_hist.Text = "∞"
            End If
        End If

        If Label_res.Text Mod 1 = 0 Then
            virgula = 0
        Else
            virgula = 1
        End If
    End Sub

    Private Sub Roundbutton13_Click(sender As Object, e As EventArgs) Handles Roundbutton_add.Click
        'estas variaveis funcionam como um bollean ou seja qunado o utilizador clica no botao 
        'o conter add adiciona 1 ou seja se o if (vezes =1) faz a multiplicação, se os conters da subtraçao,multipicaçao,
        'divisao etc.. forem = ou superiores a 1 signfica que tem de fazer o calculo primeiro por isso na label hist faz o
        'calculo e so depois é que procede para a adição
        igual = 0
        add += 1
        num = Label_res.Text
        If subs <> 1 And dividir <> 1 And vezes <> 1 Then
            If add = 1 Then
                Label_hist.Text = num & " + "
                Label_sinal.Text = "+"
                Label_res.Text = 0
            ElseIf add > 1 Then
                Label_hist.Text = Val(Label_hist.Text) + num & "+"
                Label_sinal.Text = "+"
                Label_res.Text = 0
            End If
        ElseIf subs >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) - num & "+"
            Label_sinal.Text = "+"
            Label_res.Text = 0
            subs = 0
        ElseIf dividir >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) / num & " + "
            Label_sinal.Text = "+"
            Label_res.Text = 0
            dividir = 0
        ElseIf vezes >= 1 Then
            Label_hist.Text = Val(Label_hist.Text) * num & " + "
            Label_sinal.Text = "+"
            Label_res.Text = 0
            vezes = 0
        End If

        If Label_res.Text Mod 1 = 0 Then
            virgula = 0
        Else
            virgula = 1
        End If



    End Sub

    Private Sub Roundbutton_mod_Click(sender As Object, e As EventArgs) Handles Roundbutton_mod.Click
        raiz = Label_res.Text
        Label_res.Text = Math.Sqrt(raiz)
        Label_hist.Text = raiz
        If Label_hist.Text Mod 1 = 0 Then
            virgula = 0
        Else
            virgula = 1
        End If
    End Sub


    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' aumento o width ate onde o historico aparece
        Me.Size = New Size(Me.Size.Width + 250, Me.Size.Height + 0)
    End Sub

    Private Sub OcultarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Retira o width para o inicial
        Me.Size = New Size(Me.Size.Width - 250, Me.Size.Height + 0)
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' esta funcao server para pagar caracter a caracter utilizando o lenght da label
        If Label_res.Text = " " Then
            Label_res.Text = "0"
        ElseIf Label_res.Text.Length > 0 Then
            Label_res.Text = Label_res.Text.Remove(Label_res.Text.Length - 1)
        End If
    End Sub
End Class
