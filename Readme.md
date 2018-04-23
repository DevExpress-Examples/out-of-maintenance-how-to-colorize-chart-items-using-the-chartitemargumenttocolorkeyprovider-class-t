# How to colorize chart items using the ChartItemArgumentToColorKeyProvider class


<p> The following example demonstrates how to colorize chart items using the <strong>ChartItemArgumentToColorKeyProvider</strong> class as a color information provider.</p>
<p> For this, create a <strong>ChartItemArgumentToColorKeyProvider</strong> object and assign it to the <strong>KeyValueColorizer.ColorItemKeyProvider</strong> property.</p>
<p>Then, create a few <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapColorizerColorTextItemtopic">ColorizerColorTextItem</a> objects with keys, which represent arguments of chart items and add them to the colorizer via its <strong>KeyValueColorizer.AddItem</strong> method.<br /><br />Starting with the 14.2 version, you should use KeyColorColorizer. The following examples demonstrate how to use this colorizer: <a href="http://devexpress.com/example=T116230">How to manually add MapBubble items to the map</a> and <a href="http://devexpress.com/example=T116241">How to manually add MapPie items to the map</a>.</p>

<br/>


