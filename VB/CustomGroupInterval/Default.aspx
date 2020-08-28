<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="CustomGroupInterval.DefaultForm" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v17.2, Version=17.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" ValueType="System.String" SelectedIndex="0"
            AutoPostBack="True" OnSelectedIndexChanged="ASPxComboBox1_SelectedIndexChanged" Caption="Select Group Interval">
            <RootStyle CssClass="OptionsBottomMargin"></RootStyle>
            <Items>
                <dx:ListEditItem Text="Group Products by First Characters" Value="0" />
                <dx:ListEditItem Text="Group Sales by Year and Quarter" Value="1" />
            </Items>
        </dx:ASPxComboBox>
        <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" DataSourceID="ProductReportsDataSource"
            CssClass="" OnCustomGroupInterval="ASPxPivotGrid1_CustomGroupInterval" OnDataBound="ASPxPivotGrid1_DataBound"
            Width="100%">
            <Fields>
                <dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Product Group" FieldName="ProductName"
                    ID="fieldProductName0" Visible="True" GroupInterval="Custom" />
                <dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Product" FieldName="ProductName"
                    ID="fieldProductName1" />
                <dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Sales" FieldName="ProductSales"
                    ID="fieldProductSales" />
                <dx:PivotGridField Area="ColumnArea" AreaIndex="0" Caption="Year - Quarter" FieldName="ShippedDate"
                    ID="fieldShippedDate0" Visible="False" />
                <dx:PivotGridField Area="ColumnArea" AreaIndex="1" Caption="Shipped Date" FieldName="ShippedDate"
                    ID="fieldShippedDate1" GroupInterval="DateYear" />
            </Fields>
            <OptionsView ShowFilterHeaders="False" HorizontalScrollBarMode="Auto" />
            <OptionsFilter NativeCheckBoxes="False" />
        </dx:ASPxPivotGrid>
        <asp:AccessDataSource ID="ProductReportsDataSource" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT * FROM [ProductReports]"></asp:AccessDataSource>
    </div>
    </form>
</body>
</html>