using System;
using DevExpress.XtraPivotGrid;

namespace CustomGroupInterval {
    public partial class DefaultForm : System.Web.UI.Page {
        private int SelectedDemo {
            get { return Convert.ToInt32(ASPxComboBox1.SelectedItem.Value); }
        }
        protected void Page_Load(object sender, EventArgs e) {

        }
        protected void ASPxPivotGrid1_CustomGroupInterval(object sender, DevExpress.Web.ASPxPivotGrid.PivotCustomGroupIntervalEventArgs e) {
            switch(SelectedDemo) {
                case 0:
                    if(!object.ReferenceEquals(e.Field, ASPxPivotGrid1.Fields[0])) return;
                    if(Convert.ToChar(e.Value.ToString()[0]) < 'F') {
                        e.GroupValue = "A-E";
                        return;
                    }
                    if(Convert.ToChar(e.Value.ToString()[0]) > 'E' && Convert.ToChar(e.Value.ToString()[0]) < 'T') {
                        e.GroupValue = "F-S";
                        return;
                    }
                    if(Convert.ToChar(e.Value.ToString()[0]) > 'S')
                        e.GroupValue = "T-Z";
                    break;
                case 1:
                    if(!object.ReferenceEquals(e.Field, ASPxPivotGrid1.Fields[3])) return;
                    e.GroupValue = ((DateTime)e.Value).Year + " - " + ((((DateTime)e.Value).Month - 1) / 3 + 1).ToString();
                    break;
            }
        }
        protected void ASPxComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            ASPxPivotGrid1.BeginUpdate();
            switch(SelectedDemo) {
                case 0:
                    ASPxPivotGrid1.Fields[0].Visible = true;
                    ASPxPivotGrid1.Fields[0].Caption = "Product Group";
                    ASPxPivotGrid1.Fields[0].GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom;
                    ASPxPivotGrid1.Fields[0].AreaIndex = 0;
                    ASPxPivotGrid1.Fields[4].Caption = "Year";
                    ASPxPivotGrid1.Fields[4].FilterValues.Clear();
                    ASPxPivotGrid1.Fields[4].GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
                    ASPxPivotGrid1.Fields[3].Visible = false;
                    ASPxPivotGrid1.Fields[3].GroupInterval = PivotGroupInterval.Default;
                    break;
                case 1:
                    ASPxPivotGrid1.Fields[3].Visible = true;
                    ASPxPivotGrid1.Fields[3].Caption = "Year - Quarter";
                    ASPxPivotGrid1.Fields[3].GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom;
                    ASPxPivotGrid1.Fields[3].AreaIndex = 0;
                    ASPxPivotGrid1.Fields[4].Caption = "Shipped Date";
                    ASPxPivotGrid1.Fields[4].FilterValues.Clear();
                    ASPxPivotGrid1.Fields[4].GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Default;
                    ASPxPivotGrid1.Fields[4].AreaIndex = 1;
                    ASPxPivotGrid1.Fields[0].Visible = false;
                    ASPxPivotGrid1.Fields[0].GroupInterval = PivotGroupInterval.Default;
                    break;
            }
            ASPxPivotGrid1.EndUpdate();
            ASPxPivotGrid1.CollapseAll();
        }
        protected void ASPxPivotGrid1_DataBound(object sender, EventArgs e) {
            if(!IsPostBack) ASPxPivotGrid1.CollapseAll();
        }
    }
}