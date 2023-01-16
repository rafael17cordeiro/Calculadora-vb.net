Imports System.CodeDom
Imports System.Drawing.Drawing2D
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

    Private Sub Form2_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)
        Using pn As New Pen(Color.Black, 2)
            e.Graphics.DrawPath(pn, path)
        End Using
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        If TextBox1.Text = "" Then
            MsgBox("Escreva a quantia que pretende converter")
        End If
        valor = TextBox1.Text
        If ComboBox1.SelectedIndex = 0 Then
            Select Case ComboBox2.SelectedIndex
                Case 0
                    Label11.Text = valor & " Euros"
                Case 1
                    Label11.Text = valor * exchangeRate_libra & " Libras"
                Case 2
                    Label11.Text = valor * exchangeRate_dollar & "Dollars"
            End Select
        End If





        '------------------fim secçao euros----------
        If ComboBox1.SelectedIndex = 1 Then
            Select Case ComboBox2.SelectedIndex
                Case 0
                    Label11.Text = valor * exchangeRate_eur & " Euros"
                Case 1
                    Label11.Text = valor & " Libras"
                Case 2
                    Label11.Text = valor * exchangeRate_dollar & " Dollars"
            End Select
        End If

        '----------------------Fim secçao libra --------------------------
        If ComboBox1.SelectedIndex = 2 Then
            Select Case ComboBox2.SelectedIndex
                Case 0
                    Label11.Text = valor * exchangeRate_eur & "Euros"
                Case 1
                    Label11.Text = valor * exchangeRate_libra & " Libras"
                Case 2
                    Label11.Text = valor & " Dollars"
            End Select
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
        If TextBox2.Text = "" Then
            MsgBox("Escreva a quantia que pretende converter")
        End If
        valor = TextBox2.Text

        If ComboBox4.SelectedIndex = 0 Then
            Select Case ComboBox3.SelectedIndex
                Case 0
                    Label12.Text = valor & "milimetros"
                Case 1
                    Label12.Text = valor / 10 & " centimetros"
                Case 2
                    Label12.Text = valor / 100 & " decimetros"
                Case 3
                    Label12.Text = valor / 1000 & " metros"
                Case 4
                    Label12.Text = valor / 1000000 & " kilometros"
            End Select
        End If

        '------------------------------Fim seleção milimetros---------------------------

        If ComboBox4.SelectedIndex = 1 Then
            Select Case ComboBox3.SelectedIndex
                Case 0
                    Label12.Text = valor * 10 & "milimetros"
                Case 1
                    Label12.Text = valor & "centimeros"
                Case 2
                    Label12.Text = valor / 10 & "Decimetros"
                Case 3
                    Label12.Text = valor / 100 & "metros"
                Case 4
                    Label12.Text = valor / 100000 & "Kilometros"
            End Select
        End If


        '------------------------fim secçao centimetros--------------------------
        If ComboBox4.SelectedIndex = 2 Then
            Select Case ComboBox3.SelectedIndex
                Case 0
                    Label12.Text = valor * 100 & "milimetros"
                Case 1
                    Label12.Text = valor * 10 & " centimetros"
                Case 2
                    Label12.Text = valor & " decimetros"
                Case 3
                    Label12.Text = valor / 10 & "metros"
                Case 4
                    Label12.Text = valor / 1000 & "Kilometros"
            End Select
        End If
        '----------------------------fim secçao decimetros-------------------------
        If ComboBox4.SelectedIndex = 3 Then
            Select Case ComboBox3.SelectedIndex
                Case 0
                    Label12.Text = valor * 1000 & "milimetros"
                Case 1
                    Label12.Text = valor * 100 & " centimetros"
                Case 2
                    Label12.Text = valor * 10 & " decimetros"
                Case 3
                    Label12.Text = valor & "metros"
                Case 4
                    Label12.Text = valor / 1000 & "Kilometros"
            End Select
        End If
        '----------------------------fim secçao metros-------------------------
        If ComboBox4.SelectedIndex = 4 Then
            Select Case ComboBox3.SelectedIndex
                Case 0
                    Label12.Text = valor * 1000000 & " Milimetros"
                Case 1
                    Label12.Text = valor * 100000 & " centimetros"
                Case 2
                    Label12.Text = valor * 10000 & " decimetros"
                Case 3
                    Label12.Text = valor * 1000 & "metros"
                Case 4
                    Label12.Text = valor & "Kilometros"
            End Select
        End If
        '----------------------------fim secçao kilometros-------------------------
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim valor As Double
        If TextBox3.Text = "" Then
            MsgBox("Escreva a quantia que pretende converter")
        End If
        valor = TextBox3.Text
        If ComboBox6.SelectedIndex = 0 Then
            Select Case ComboBox5.SelectedIndex
                Case 0
                    Label13.Text = valor & " Bytes"
                Case 1
                    Label13.Text = valor / 1024 & " KiloBytes"
                Case 2
                    Label13.Text = valor / (1024 * 1024) & " MegaBytes"
                Case 3
                    Label13.Text = valor / (1024 * 1024 * 1024) & " GigaBytes"
                Case 4
                    Label13.Text = valor / 1000000000000 & " TeraBytes"
            End Select
        End If



        '---------------------------Fim secçao bytes------------------------
        If ComboBox6.SelectedIndex = 1 Then
            Select Case ComboBox5.SelectedIndex
                Case 0
                    Label13.Text = valor * 1024 & " Bytes"
                Case 1
                    Label13.Text = valor & " KiloBytes"
                Case 2
                    Label13.Text = valor / 1024 & " Megabytes"
                Case 3
                    Label13.Text = valor / (1024 * 1024) & " GigaBytes"
                Case 4
                    Label13.Text = valor / (1024 * 1024 * 1024) & " TeraBytes"
            End Select
        End If



        '--------------------------Fim secçao kilkobytes ------------------
        If ComboBox6.SelectedIndex = 2 Then
            Select Case ComboBox5.SelectedIndex
                Case 0
                    Label13.Text = valor * (1024 * 1024) & " Bytes"
                Case 1
                    Label13.Text = valor * 1024 & " Kilobytes"
                Case 2
                    Label13.Text = valor & " Megabytes"
                Case 3
                    Label13.Text = valor / 1024 & " GigaBytes"
                Case 4
                    Label13.Text = valor / (1024 * 1024) & " TeraBytes"
            End Select
        End If


        '-----------------------Fim secção Mega bytes ------------------
        If ComboBox6.SelectedIndex = 2 Then
            Select Case ComboBox5.SelectedIndex
                Case 0
                    Label13.Text = valor * (1024 * 1024 * 1024) & " Bytes"
                Case 1
                    Label13.Text = valor * (1024 * 1024) & " Kilobytes"
                Case 2
                    Label13.Text = valor * 1024 & " Megabytes"
                Case 3
                    Label13.Text = valor & " GigaBytes"
                Case 4
                    Label13.Text = valor / 1024 & " TeraBytes"
            End Select
        End If


        '-----------------------Fim secção gigabyes ----------------------
        If ComboBox6.SelectedIndex = 2 Then
            Select Case ComboBox5.SelectedIndex
                Case 0
                    Label13.Text = valor * 1000000000000 & " Bytes"
                Case 1
                    Label13.Text = valor * (1024 * 1024 * 1024) & " Kilobytes"
                Case 2
                    Label13.Text = valor * 1024 * 1024 & " Megabytes"
                Case 3
                    Label13.Text = valor * 1024 & " GigaBytes"
                Case 4
                    Label13.Text = valor & " TeraBytes"
            End Select
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Select Case ComboBox1.SelectedItem
            Case "Miligrama (mg)"
                Select Case ComboBox2.SelectedItem
                    Case "Grama (g)"
                        Label15.Text = (TextBox5.Text * 0.001).ToString()
                    Case "Quiliograma (kg)"
                        Label15.Text = (TextBox5.Text * 0.000001).ToString()
                    Case "Tonelada (T)"
                        Label15.Text = (TextBox5.Text * 0.000000001).ToString()
                End Select
            Case "Grama (g)"
                Select Case ComboBox2.SelectedItem
                    Case "Miligrama (mg)"
                        Label15.Text = (TextBox5.Text * 1000).ToString()
                    Case "Quiliograma (kg)"
                        Label15.Text = (TextBox5.Text * 0.001).ToString()
                    Case "Tonelada (T)"
                        Label15.Text = (TextBox5.Text * 0.000001).ToString()
                End Select
            Case "Quiliograma (kg)"
                Select Case ComboBox2.SelectedItem
                    Case "Miligrama (mg)"
                        Label15.Text = (TextBox5.Text * 1000000).ToString()
                    Case "Grama (g)"
                        Label15.Text = (TextBox5.Text * 1000).ToString()
                    Case "Tonelada (T)"
                        Label15.Text = (TextBox5.Text * 0.001).ToString()
                End Select
            Case "Tonelada (T)"
                Select Case ComboBox2.SelectedItem
                    Case "Miligrama (mg)"
                        Label15.Text = (TextBox5.Text * 1000000000).ToString()
                    Case "Grama (g)"
                        Label15.Text = (TextBox5.Text * 1000000).ToString()
                    Case "Quiliograma (kg)"
                        Label15.Text = (TextBox5.Text * 1000).ToString()
                End Select
        End Select
    End Sub


    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.BackColor = Color.White
        Label3.ForeColor = Color.Black
        Label6.ForeColor = Color.Black
        Label9.ForeColor = Color.Black
        Label24.ForeColor = Color.Black
        Label21.ForeColor = Color.Black
        Label18.ForeColor = Color.Black
        Label11.ForeColor = Color.Black
        Label12.ForeColor = Color.Black
        Label13.ForeColor = Color.Black
        Label16.ForeColor = Color.Black
        Label15.ForeColor = Color.Black
        Label14.ForeColor = Color.Black
        Label26.Visible = True
        PictureBox7.Visible = True
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.BackColor = Color.Black
        Label3.ForeColor = Color.White
        Label6.ForeColor = Color.White
        Label9.ForeColor = Color.White
        Label24.ForeColor = Color.White
        Label21.ForeColor = Color.White
        Label18.ForeColor = Color.White
        Label11.ForeColor = Color.White
        Label12.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label16.ForeColor = Color.White
        Label15.ForeColor = Color.White
        Label14.ForeColor = Color.White
        Label26.Visible = False
        PictureBox7.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class