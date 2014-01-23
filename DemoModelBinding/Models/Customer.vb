Imports System.ComponentModel.DataAnnotations

Public Class Customer
    Public Property id As Integer
    <Required> <Display(Name:="First name")>
    Public Property FirstName As String
    <Required> <Display(Name:="Last name")>
    Public Property LastName As String

    Public Property Account As String
End Class
