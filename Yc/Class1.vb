Public Class Class1

    Private mPrp1 As String
    Public Property Prp1 As String
        Get
            Return Me.mPrp1
        End Get
        Set(value As String)
            Me.mPrp1 = value
        End Set
    End Property

    Public Sub New()
        Dim a = ""
    End Sub
End Class
