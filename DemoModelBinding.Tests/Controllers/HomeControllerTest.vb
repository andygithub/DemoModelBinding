﻿Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Web.Mvc
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports DemoModelBinding

<TestClass()> Public Class HomeControllerTest

    <TestMethod()> Public Sub Index()
        ' Arrange
        Dim controller As New HomeController()

        ' Act
        Dim result As ViewResult = DirectCast(controller.Index(), ViewResult)

        ' Assert
        Assert.IsNotNull(result)
    End Sub

End Class
