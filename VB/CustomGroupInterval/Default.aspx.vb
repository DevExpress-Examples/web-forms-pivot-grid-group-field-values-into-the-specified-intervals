Imports System
Imports DevExpress.XtraPivotGrid

Namespace CustomGroupInterval
    Partial Public Class DefaultForm
        Inherits System.Web.UI.Page

        Private ReadOnly Property SelectedDemo() As Integer
            Get
                Return Convert.ToInt32(ASPxComboBox1.SelectedItem.Value)
            End Get
        End Property
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub
        Protected Sub ASPxPivotGrid1_CustomGroupInterval(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.PivotCustomGroupIntervalEventArgs)
            Select Case SelectedDemo
                Case 0
                    If Not Object.ReferenceEquals(e.Field, ASPxPivotGrid1.Fields(0)) Then
                        Return
                    End If
                    If Convert.ToChar(e.Value.ToString().Chars(0)) < "F"c Then
                        e.GroupValue = "A-E"
                        Return
                    End If
                    If Convert.ToChar(e.Value.ToString().Chars(0)) > "E"c AndAlso Convert.ToChar(e.Value.ToString().Chars(0)) < "T"c Then
                        e.GroupValue = "F-S"
                        Return
                    End If
                    If Convert.ToChar(e.Value.ToString().Chars(0)) > "S"c Then
                        e.GroupValue = "T-Z"
                    End If
                Case 1
                    If Not Object.ReferenceEquals(e.Field, ASPxPivotGrid1.Fields(3)) Then
                        Return
                    End If
                    e.GroupValue = CDate(e.Value).Year & " - " & ((CDate(e.Value).Month - 1) \ 3 + 1).ToString()
            End Select
        End Sub
        Protected Sub ASPxComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ASPxPivotGrid1.BeginUpdate()
            Select Case SelectedDemo
                Case 0
                    ASPxPivotGrid1.Fields(0).Visible = True
                    ASPxPivotGrid1.Fields(0).Caption = "Product Group"
                    ASPxPivotGrid1.Fields(0).GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom
                    ASPxPivotGrid1.Fields(0).AreaIndex = 0
                    ASPxPivotGrid1.Fields(4).Caption = "Year"
                    ASPxPivotGrid1.Fields(4).FilterValues.Clear()
                    ASPxPivotGrid1.Fields(4).GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
                    ASPxPivotGrid1.Fields(3).Visible = False
                    ASPxPivotGrid1.Fields(3).GroupInterval = PivotGroupInterval.Default
                Case 1
                    ASPxPivotGrid1.Fields(3).Visible = True
                    ASPxPivotGrid1.Fields(3).Caption = "Year - Quarter"
                    ASPxPivotGrid1.Fields(3).GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom
                    ASPxPivotGrid1.Fields(3).AreaIndex = 0
                    ASPxPivotGrid1.Fields(4).Caption = "Shipped Date"
                    ASPxPivotGrid1.Fields(4).FilterValues.Clear()
                    ASPxPivotGrid1.Fields(4).GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Default
                    ASPxPivotGrid1.Fields(4).AreaIndex = 1
                    ASPxPivotGrid1.Fields(0).Visible = False
                    ASPxPivotGrid1.Fields(0).GroupInterval = PivotGroupInterval.Default
            End Select
            ASPxPivotGrid1.EndUpdate()
            ASPxPivotGrid1.CollapseAll()
        End Sub
        Protected Sub ASPxPivotGrid1_DataBound(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsPostBack Then
                ASPxPivotGrid1.CollapseAll()
            End If
        End Sub
    End Class
End Namespace