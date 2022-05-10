Public Class Bank
    Public Property nickels As Integer
    Public Property quarters As Integer
    Public Property dimes As Integer
    Public ReadOnly Property total As Decimal
        Get
            Return m_total
        End Get
    End Property
    Dim m_total As Decimal
    Public Sub Buy(Amount As Decimal)
        If Amount <= m_total Then
            m_total = m_total - Amount
        End If
    End Sub

    Public Sub addNickel()
        nickels = nickels + 1
        m_total = m_total + 0.05
    End Sub

    Public Sub addQuarters()
        quarters = quarters + 1
        m_total = m_total + 0.25
    End Sub

    Public Sub addDimes()
        dimes = dimes + 1
        m_total = m_total + 0.1
    End Sub

End Class
