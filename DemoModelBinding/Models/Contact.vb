Imports System.ComponentModel.DataAnnotations

Public Class Contact
    Public Property Contactid As Integer
    <Required> <Display(Name:="First name")>
    Public Property ContactFirstName As String
    <Required> <Display(Name:="Last name")>
    Public Property ContactLastName As String

    Public Property ContactType As String
End Class
