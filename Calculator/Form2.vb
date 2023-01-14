Imports System.IO

Public Class Form2
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
        Form1.Hide()

        With Me

            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With
        With borderForm
            .ShowInTaskbar = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .StartPosition = FormStartPosition.Manual
            .BackColor = Color.Black
            .Opacity = 0.25
            Dim r As Rectangle = Me.Bounds
            r.Inflate(2, 2)
            .Bounds = r
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
            r = New Rectangle(3, 3, Me.Width - 4, Me.Height - 4)
            .Region.Exclude(RoundedRectangle(r, 48))
            .Show(Me)
        End With


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Double
        Dim exchangeRate_libra As Double = 0.89 'libra
        Dim exchangeRate_dollar As Double = 1.08 'dollar
        Dim exchangeRate_eur As Double = 1.16 '
        valor = TextBox1.Text
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 0 Then
            Label11.Text = valor & " Euros"
        End If
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 1 Then 'euro para libra
            Label11.Text = valor * exchangeRate_libra & " Libras"
        End If
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 2 Then 'euro para dolar
            Label11.Text = valor * exchangeRate_dollar & "Dollars"
        End If
        '------------------fim secçao euros----------
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 0 Then 'libra par eur
            Label11.Text = valor * exchangeRate_eur & " Euros"
        End If
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 1 Then 'libra para libra
            Label11.Text = valor & " Libras"
        End If
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 2 Then 'libra para dolar
            Label11.Text = valor * exchangeRate_dollar & " Dollars"
        End If
        '----------------------Fim secçao libra --------------------------
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 0 Then 'dolar para euro
            Label11.Text = valor * exchangeRate_eur & "Euros"
        End If
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 1 Then 'dolar para libra
            Label11.Text = valor * exchangeRate_libra & " Libras"
        End If
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 2 Then 'dolar para dolar
            Label11.Text = valor * exchangeRate_dollar & " Dollars"
        End If
        '--------------------fim secçao dolar---------------------------------
    End Sub

    Private Sub TextBox1_TextClick(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox2_TextClick(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
    End Sub
    Private Sub TextBox3_TextClick(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox3.Text = ""
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valor As Double
        valor = TextBox2.Text
        If ComboBox4.SelectedIndex = 0 And ComboBox3.SelectedIndex = 0 Then
            Label12.Text = valor & "milimetros"
        End If
        If ComboBox4.SelectedIndex = 0 And ComboBox3.SelectedIndex = 1 Then
            Label12.Text = valor / 10 & " centimetros"
        End If
        If ComboBox4.SelectedIndex = 0 And ComboBox3.SelectedIndex = 2 Then
            Label12.Text = valor / 100 & " decimetros"
        End If
        If ComboBox4.SelectedIndex = 0 And ComboBox3.SelectedIndex = 3 Then
            Label12.Text = valor / 1000 & " metros"
        End If
        If ComboBox4.SelectedIndex = 0 And ComboBox3.SelectedIndex = 4 Then
            Label12.Text = valor / 1000000 & " kilometros"
        End If
        '------------------------------Fim seleção milimetros---------------------------
        If ComboBox4.SelectedIndex = 1 And ComboBox3.SelectedIndex = 0 Then
            Label12.Text = valor * 10 & "milimetros"
        End If
        If ComboBox4.SelectedIndex = 1 And ComboBox3.SelectedIndex = 1 Then
            Label12.Text = valor & "centimeros"
        End If
        If ComboBox4.SelectedIndex = 1 And ComboBox3.SelectedIndex = 2 Then
            Label12.Text = valor / 10 & "Decimetros"
        End If
        If ComboBox4.SelectedIndex = 1 And ComboBox3.SelectedIndex = 3 Then
            Label12.Text = valor / 100 & "metros"
        End If
        If ComboBox4.SelectedIndex = 1 And ComboBox3.SelectedIndex = 4 Then
            Label12.Text = valor / 100000 & "kILOMETROS"
        End If
        '------------------------fim secçao centimetros--------------------------
        If ComboBox4.SelectedIndex = 2 And ComboBox3.SelectedIndex = 0 Then
            Label12.Text = valor * 100 & "milimetros"
        End If
        If ComboBox4.SelectedIndex = 2 And ComboBox3.SelectedIndex = 1 Then
            Label12.Text = valor * 10 & " centimetros"
        End If
        If ComboBox4.SelectedIndex = 2 And ComboBox3.SelectedIndex = 2 Then
            Label12.Text = valor & " decimetros"
        End If
        If ComboBox4.SelectedIndex = 2 And ComboBox3.SelectedIndex = 3 Then
            Label12.Text = valor / 10 & " Metros"
        End If
        If ComboBox4.SelectedIndex = 2 And ComboBox3.SelectedIndex = 4 Then
            Label12.Text = valor / 10000 & " kilometros"
        End If
        '----------------------------fim secçao decimetros-------------------------
        If ComboBox4.SelectedIndex = 3 And ComboBox3.SelectedIndex = 0 Then
            Label12.Text = valor * 1000 & "milimetros"
        End If
        If ComboBox4.SelectedIndex = 3 And ComboBox3.SelectedIndex = 1 Then
            Label12.Text = valor * 100 & "centimetros"
        End If
        If ComboBox4.SelectedIndex = 3 And ComboBox3.SelectedIndex = 2 Then
            Label12.Text = valor * 10 & "decimetros"
        End If
        If ComboBox4.SelectedIndex = 3 And ComboBox3.SelectedIndex = 3 Then
            Label12.Text = valor
        End If
        If ComboBox4.SelectedIndex = 3 And ComboBox3.SelectedIndex = 4 Then
            Label12.Text = valor / 1000 & "kilometros"
        End If
        '----------------------------fim secçao metros-------------------------
        If ComboBox4.SelectedIndex = 4 And ComboBox3.SelectedIndex = 0 Then
            Label12.Text = valor * 1000000 & " Milimetros"
        End If
        If ComboBox4.SelectedIndex = 4 And ComboBox3.SelectedIndex = 1 Then
            Label12.Text = valor * 100000
        End If
        If ComboBox4.SelectedIndex = 4 And ComboBox3.SelectedIndex = 2 Then
            Label12.Text = valor * 10000
        End If
        If ComboBox4.SelectedIndex = 4 And ComboBox3.SelectedIndex = 3 Then
            Label12.Text = valor * 1000
        End If
        If ComboBox4.SelectedIndex = 4 And ComboBox3.SelectedIndex = 4 Then
            Label12.Text = valor
        End If
        '----------------------------fim secçao kilometros-------------------------
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim valor As Double
        valor = TextBox3.Text
        If ComboBox6.SelectedIndex = 0 And ComboBox5.SelectedIndex = 0 Then
            Label13.Text = valor & " Bytes"
        End If
        If ComboBox6.SelectedIndex = 0 And ComboBox5.SelectedIndex = 1 Then
            Label13.Text = valor / 1024 & " KiloBytes"
        End If
        If ComboBox6.SelectedIndex = 0 And ComboBox5.SelectedIndex = 2 Then
            Label13.Text = valor / (1024 * 1024) & " MegaBytes"
        End If
        If ComboBox6.SelectedIndex = 0 And ComboBox5.SelectedIndex = 3 Then
            Label13.Text = valor / (1024 * 1024 * 1024) & " GigaBytes"
        End If
        If ComboBox6.SelectedIndex = 0 And ComboBox5.SelectedIndex = 4 Then
            Label13.Text = valor / 1000000000000 & " TeraBytes"
        End If

        '---------------------------Fim secçao bytes------------------------
        If ComboBox6.SelectedIndex = 1 And ComboBox5.SelectedIndex = 0 Then
            Label13.Text = valor * 1024 & " Bytes"
        End If
        If ComboBox6.SelectedIndex = 1 And ComboBox5.SelectedIndex = 1 Then
            Label13.Text = valor & " Kilobytes"
        End If
        If ComboBox6.SelectedIndex = 1 And ComboBox5.SelectedIndex = 2 Then
            Label13.Text = valor / 1024 & " Megabytes"
        End If
        If ComboBox6.SelectedIndex = 1 And ComboBox5.SelectedIndex = 3 Then
            Label13.Text = valor / (1024 * 1024) & " GigaBytes"
        End If
        If ComboBox6.SelectedIndex = 1 And ComboBox5.SelectedIndex = 4 Then
            Label13.Text = valor / (1024 * 1024 * 1024) & " TeraBytes"
        End If

        '--------------------------Fim secçao kilkobytes ------------------
        If ComboBox6.SelectedIndex = 2 And ComboBox5.SelectedIndex = 0 Then
            Label13.Text = valor * (1024 * 1024) & " Bytes"
        End If
        If ComboBox6.SelectedIndex = 2 And ComboBox5.SelectedIndex = 1 Then
            Label13.Text = valor * 1024 & " Kilobytes"
        End If
        If ComboBox6.SelectedIndex = 2 And ComboBox5.SelectedIndex = 2 Then
            Label13.Text = valor & " Megabytes"
        End If
        If ComboBox6.SelectedIndex = 2 And ComboBox5.SelectedIndex = 3 Then
            Label13.Text = valor / 1024 & " GigaBytes"
        End If
        If ComboBox6.SelectedIndex = 2 And ComboBox5.SelectedIndex = 4 Then
            Label13.Text = valor / (1024 * 1024) & " TeraBytes"
        End If
        '-----------------------Fim secção Mega bytes ------------------
        If ComboBox6.SelectedIndex = 3 And ComboBox5.SelectedIndex = 0 Then
            Label13.Text = valor * (1024 * 1024 * 1024) & " Bytes"
        End If
        If ComboBox6.SelectedIndex = 3 And ComboBox5.SelectedIndex = 1 Then
            Label13.Text = valor * (1024 * 1024) & " Kilobytes"
        End If
        If ComboBox6.SelectedIndex = 3 And ComboBox5.SelectedIndex = 2 Then
            Label13.Text = valor * 1024 & " Megabytes"
        End If
        If ComboBox6.SelectedIndex = 3 And ComboBox5.SelectedIndex = 3 Then
            Label13.Text = valor & " GigaBytes"
        End If
        If ComboBox6.SelectedIndex = 3 And ComboBox5.SelectedIndex = 4 Then
            Label13.Text = valor / 1024 & " TeraBytes"
        End If
        '-----------------------Fim secção gigabyes ----------------------
        If ComboBox6.SelectedIndex = 4 And ComboBox5.SelectedIndex = 0 Then
            Label13.Text = valor * 1000000000000 & " Bytes"
        End If
        If ComboBox6.SelectedIndex = 4 And ComboBox5.SelectedIndex = 1 Then
            Label13.Text = valor * (1024 * 1024 * 1024) & " Kilobytes"
        End If
        If ComboBox6.SelectedIndex = 4 And ComboBox5.SelectedIndex = 2 Then
            Label13.Text = valor * 1024 * 1024 & " Megabytes"
        End If
        If ComboBox6.SelectedIndex = 4 And ComboBox5.SelectedIndex = 3 Then
            Label13.Text = valor * 1024 & " GigaBytes"
        End If
        If ComboBox6.SelectedIndex = 4 And ComboBox5.SelectedIndex = 4 Then
            Label13.Text = valor & " TeraBytes"
        End If
    End Sub
End Class