Public Class pie
    Dim xoffset As Integer
    Dim yoffset As Integer
    Public Property xSpeed As Integer
    Public Property ySpeed As Integer
    Public Property Pen As Pen
    Public Property w As Integer
    Public Property h As Integer
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point

    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            xOffset += xSpeed
            yOffset += ySpeed

            g.DrawPie(Pen, m_a.X + xoffset, m_a.Y + yoffset, w + xoffset, h + yoffset, 0, 90)

        End Using

    End Sub
End Class
