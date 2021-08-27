<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576133/14.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T140139)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))**
<!-- default file list end -->
# How to colorize chart items using the ChartItemArgumentToColorKeyProvider class


<p> The following example demonstrates how to colorize chart items using the <strong>ChartItemArgumentToColorKeyProvider</strong> class as a color information provider.</p>
<p> For this, create a <strong>ChartItemArgumentToColorKeyProvider</strong> object and assign it to the <strong>KeyValueColorizer.ColorItemKeyProvider</strong> property.</p>
<p>Then, create a few <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapColorizerColorTextItemtopic">ColorizerColorTextItem</a> objects with keys, which represent arguments of chart items and add them to the colorizer via its <strong>KeyValueColorizer.AddItem</strong> method.<br /><br />Starting with the 14.2 version, you should use KeyColorColorizer. The following examples demonstrate how to use this colorizer: <a href="http://devexpress.com/example=T116230">How to manually add MapBubble items to the map</a> and <a href="http://devexpress.com/example=T116241">How to manually add MapPie items to the map</a>.</p>

<br/>


