Imports System.ComponentModel.DataAnnotations

Public Class Address
    Public Property id As Integer
    <Required> <Display(Name:="Address Line 1")>
    Public Property AddressLine1 As String
    <Required> <Display(Name:="Address Line 2")>
    Public Property AddressLine2 As String
    Public Property City As String
    Public Property State As String

    Public Property ZipCode As String
End Class

