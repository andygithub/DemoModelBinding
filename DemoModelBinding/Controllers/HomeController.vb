Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    <HttpPost>
    Function ExampleForm(addressline1 As String, firstname As String, lastname As String, contactfirstname As String, contactlastname As String) As ActionResult
        'all values are mapped
        Return View("Index")
    End Function

    Function ExampleFormAdress(item As Address)
        'all values are mapped
        Return View("Index")
    End Function

    Function ExampleFormMultiple(item As Address, itemtewo As Customer)
        'all values are mapped
        Return View("Index")
    End Function

    Function ExampleFormCombined(item As CombinedModel)
        'nothing is mapped
        Return View("Index")
    End Function

    Function ExampleFormHCSISCombined(item As PasteModel)
        'all values are mapped
        Return View("Index")
    End Function

End Class
