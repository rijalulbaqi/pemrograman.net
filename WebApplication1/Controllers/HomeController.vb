Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Deskripsi."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Alamat."

        Return View()
    End Function
End Class
