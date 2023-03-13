<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CustomGroupInterval.DefaultForm" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v22.1, Version=22.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v22.1, Version=22.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" DataSourceID="ProductReportsDataSource"
            CssClass=""  OnDataBound="ASPxPivotGrid1_DataBound"
            Width="100%">
            <Fields>
                <dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Product Group" 
                    ID="fieldProductName0" Visible="True" GroupInterval="Custom">
                      <DataBindingSerializable>
                        <dx:ExpressionDataBinding Expression="Iif(Substring([fieldProductName1], 0, 1) &lt; 'F', 'A-E', Substring([fieldProductName1], 0, 1) &lt; 'T', 'F-S', 'T-Z')" />
                    </DataBindingSerializable>
                     </dx:PivotGridField>
                <dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Product"
                    ID="fieldProductName1">
                     <DataBindingSerializable>
                        <dx:DataSourceColumnBinding ColumnName="ProductName" />
                    </DataBindingSerializable>
                     </dx:PivotGridField>
                <dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Sales"
                    ID="fieldProductSales" >
                    <DataBindingSerializable>
                        <dx:DataSourceColumnBinding ColumnName="ProductSales" />
                    </DataBindingSerializable>
                     </dx:PivotGridField>
                <dx:PivotGridField Area="ColumnArea" AreaIndex="0" Caption="Year - Quarter" 
                    ID="fieldShippedDate0" Visible="False">
                 <DataBindingSerializable>
                        <dx:DataSourceColumnBinding ColumnName="ShippedDate" />
                    </DataBindingSerializable>
                     </dx:PivotGridField>
                <dx:PivotGridField Area="ColumnArea" AreaIndex="1" Caption="Shipped Date"
                    ID="fieldShippedDate1">
                 <DataBindingSerializable>
                        <dx:DataSourceColumnBinding ColumnName="ShippedDate" GroupInterval="DateYear" />
                    </DataBindingSerializable>
                     </dx:PivotGridField>
            </Fields>
            <OptionsView ShowFilterHeaders="False" HorizontalScrollBarMode="Auto" />
            <OptionsFilter NativeCheckBoxes="False" />
            <OptionsData DataProcessingEngine="Optimized" />
        </dx:ASPxPivotGrid>
        <asp:AccessDataSource ID="ProductReportsDataSource" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT * FROM [ProductReports]"></asp:AccessDataSource>
    </div>
    </form>
</body>
</html>
