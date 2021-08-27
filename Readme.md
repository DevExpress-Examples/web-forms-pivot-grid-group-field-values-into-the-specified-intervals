<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128577020/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T590073)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/CustomGroupInterval/Default.aspx) (VB: [Default.aspx](./VB/CustomGroupInterval/Default.aspx))
* **[Default.aspx.cs](./CS/CustomGroupInterval/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/CustomGroupInterval/Default.aspx.vb))**
<!-- default file list end -->
# ASPxPivotGrid - How to group field values into the specified intervals
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t590073/)**
<!-- run online end -->


<p>The ASPxPivotGrid control provides the <a href="https://documentation.devexpress.com/AspNet/7268/ASP-NET-WebForms-Controls/Pivot-Grid/Data-Shaping/Grouping">Custom Group Intervals</a> feature that can be used to group field values using your own criteria. To use this feature, set the field's <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.GroupInterval.property">GroupInterval</a> property to 'Custom' and provide group values using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomGroupInterval.event">CustomGroupInterval</a> event.</p>
<p>In this example, the Custom Group Intervals feature is used to group product names into the specified intervals ("A-E", "F-S" and "T-Z").</p>

<br/>


