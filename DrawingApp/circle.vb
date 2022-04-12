Public Class circle

    Public Property xSpeed As Integer
    Public Property ySpeed As Integer
    Public Property Pen As Pen
    Public Property w As Integer
    Public Property h As Integer

    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Dim xOffset As Integer
    Dim yOffset As Integer



    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a

    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            xOffset += xSpeed
            yOffset += ySpeed

            g.DrawEllipse(Pen, m_a.X + xOffset, m_a.Y + yOffset, w + xOffset, h + yOffset)
            g.DrawEllipse(Pen, m_a.X, m_a.Y, w, h)
        End Using

    End Sub
End Class
