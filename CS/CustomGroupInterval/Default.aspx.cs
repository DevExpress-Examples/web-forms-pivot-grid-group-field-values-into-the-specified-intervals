using System;
using DevExpress.XtraPivotGrid;

namespace CustomGroupInterval {
    public partial class DefaultForm : System.Web.UI.Page {
        
        protected void Page_Load(object sender, EventArgs e) {

        }
        protected void ASPxPivotGrid1_DataBound(object sender, EventArgs e) {
            if(!IsPostBack) ASPxPivotGrid1.CollapseAll();
        }
    }
}