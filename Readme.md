# ASPxPivotGrid - How to group field values into the specified intervals


<p>The ASPxPivotGrid control provides the <a href="https://documentation.devexpress.com/AspNet/7268/ASP-NET-WebForms-Controls/Pivot-Grid/Data-Shaping/Grouping">Custom Group Intervals</a> feature that can be used to group field values using your own criteria. To use this feature, set the field's <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.GroupInterval.property">GroupInterval</a> property to 'Custom' and provide group values using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomGroupInterval.event">CustomGroupInterval</a> event.</p>
<p>In this example, the Custom Group Intervals feature is used to group product names into the specified intervals ("A-E", "F-S" and "T-Z").</p>

<br/>


