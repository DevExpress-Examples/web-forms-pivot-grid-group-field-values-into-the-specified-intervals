<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128577020/22.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T590073)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Pivot Grid for Web Forms - Custom Group Intervals

The following example implements custom group intervals in the Pivot Grid to group the _Product Name_ field values into three ranges: A-E, F-S, and T-Z (according to the initial characters of the product names). The following expression is used:

`Iif(Substring([Product Name], 0, 1) < 'F', 'A-E', Substring([Product Name], 0, 1) < 'T', 'F-S', 'T-Z')`

The image below shows the result:

![CustomGroupInterval](./images/customgroupinterval6958.png)

## Files to Review

* [Default.aspx](./CS/CustomGroupInterval/Default.aspx) (VB: [Default.aspx](./VB/CustomGroupInterval/Default.aspx))
* **[Default.aspx.cs](./CS/CustomGroupInterval/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/CustomGroupInterval/Default.aspx.vb))**

## Documentation 

[Grouping](https://docs.devexpress.com/AspNet/7268/components/pivot-grid/data-shaping/grouping)

## More Examples 

[Pivot Grid for Web Forms - How to Group Date-Time Values](https://github.com/DevExpress-Examples/how-to-group-date-time-values-e1875)
