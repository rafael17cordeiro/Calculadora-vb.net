Imports Microsoft.VisualBasic
Imports sytem.drawing.drawing2D
Public Class roundbutton
    Inherits Button
    Public Sub New()
        Me.SetStyle(controlStyles.Userpaint, True)
    End Sub
    Protected Overrides Sub onpaint(Pevent As painteventargs)
        MyBase.onpaint(Pevent)
        Dim g As GraphicsPath = New graphicspath()
        g.addEllipse(0, 0 clientsize.width, clientsize.height)
        Me.region = New region(g)
    End Sub

End Class
