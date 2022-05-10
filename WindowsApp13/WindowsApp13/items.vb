Public Class items
    Public Property quarters As Integer
    Public Property gumballs As Integer
    Public Property jawbreakers As Integer
    Public ReadOnly Property contents As String
        Get
            Return "Gum: " & gumballs & " jawbreakers:" & jawbreakers & " quarters: " & quarters
        End Get
    End Property
    Public Sub restock()
        quarters = 0
        gumballs = 100
        jawbreakers = 100
    End Sub
    Public Sub addquarter()
        quarters += 1
    End Sub
    Public Function buy(item As Integer) As Boolean
        If item = 1 Then
            If quarters < 2 Or gumballs = 0 Then
                Return False
            End If
            quarters = quarters - 2
            gumballs = gumballs - 1
            Return True
        End If
        If item = 2 Then
            If quarters < 2 Or jawbreakers = 0 Then
                Return False
            End If
            quarters = quarters - 2
            jawbreakers = jawbreakers - 1
            Return True
        End If
        Return False
    End Function
End Class
