Imports System.Drawing.Drawing2D
Public Class roundbutton
    Inherits Button
    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, false)
    End Sub

    Protected Overrides Sub onpaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim g As GraphicsPath = New GraphicsPath()
        g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(g)
        MyBase.OnPaint(pevent)
    End Sub
End Class
