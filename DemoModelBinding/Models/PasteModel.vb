Imports System.ComponentModel.DataAnnotations

Public Class PasteModel

    Public Property Contactid As Integer
    <Required> <Display(Name:="First name")>
    Public Property ContactFirstName As String
    <Required> <Display(Name:="Last name")>
    Public Property ContactLastName As String

    Public Property ContactType As String

    Public Property id As Integer
    <Required> <Display(Name:="First name")>
    Public Property FirstName As String
    <Required> <Display(Name:="Last name")>
    Public Property LastName As String

    Public Property Account As String

    Public Property addressid As Integer
    <Required> <Display(Name:="Address Line 1")>
    Public Property AddressLine1 As String
    <Required> <Display(Name:="Address Line 2")>
    Public Property AddressLine2 As String
    Public Property City As String
    Public Property State As String

    Public Property ZipCode As String

    Public Property onlyForm As String

End Class
