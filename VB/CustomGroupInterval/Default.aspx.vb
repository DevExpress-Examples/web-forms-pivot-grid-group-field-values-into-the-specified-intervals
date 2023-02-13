Imports System
Imports DevExpress.XtraPivotGrid

Namespace CustomGroupInterval
    Partial Public Class DefaultForm
        Inherits System.Web.UI.Page
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub ASPxPivotGrid1_DataBound(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsPostBack Then
                ASPxPivotGrid1.CollapseAll()
            End If
        End Sub
    End Class
End Namespace