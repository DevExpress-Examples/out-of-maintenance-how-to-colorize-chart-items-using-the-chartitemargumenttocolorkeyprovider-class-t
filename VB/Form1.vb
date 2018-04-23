Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace ChartItemsKeyValueColorizer
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            InitializeMap()
        End Sub

        Private Sub InitializeMap()
            ' Create a map control with initial settings and add it to the form.
            Dim map As New MapControl() With {.Dock = DockStyle.Fill}
            Me.Controls.Add(map)

            'Create a tiles layer and add it to the Map control.
            map.Layers.Add(New ImageTilesLayer() With {.DataProvider = New OpenStreetMapDataProvider()})

            ' Create a vector items layer and add it to the Map control.
            Dim itemsLayer As New VectorItemsLayer() With {.Data = CreateData(), .Colorizer = CreateColorizer()}
            map.Layers.Add(itemsLayer)

            ' Create a legend.
            map.Legends.Add(New ColorListLegend() With {.Layer = itemsLayer})
        End Sub

        Private Function CreateData() As MapDataAdapterBase
            Dim storage As New MapItemStorage()

            ' Create bubble charts and add them to the storage.
            storage.Items.Add(New MapBubble() With {.Argument = "A", .Value = 100, .Location = New GeoPoint(-50, -70), .Size = 100})
            storage.Items.Add(New MapBubble() With {.Argument = "B", .Value = 70, .Location = New GeoPoint(-50, 0), .Size = 70})
            storage.Items.Add(New MapBubble() With {.Argument = "C", .Value = 120, .Location = New GeoPoint(-50, 70), .Size = 120})

            'Create a pie chart and add it to the storage.
            Dim pie As New MapPie() With {.Location = New GeoPoint(30, 0), .Size = 100}
            pie.Segments.Add(New PieSegment() With {.Argument = "A", .Value = 100})
            pie.Segments.Add(New PieSegment() With {.Argument = "B", .Value = 50})
            pie.Segments.Add(New PieSegment() With {.Argument = "C", .Value = 120})
            storage.Items.Add(pie)

            Return storage
        End Function

        Private Function CreateColorizer() As MapColorizer
            Dim colorizer As New KeyValueColorizer() With {.ColorItemKeyProvider = New ChartItemArgumentToColorKeyProvider()}
            colorizer.AddItem("A", New ColorizerColorTextItem(Color.Coral, "Argument A"))
            colorizer.AddItem("B", New ColorizerColorTextItem(Color.Orange, "Argument B"))
            colorizer.AddItem("C", New ColorizerColorTextItem(Color.LightBlue, "Argument C"))

            Return colorizer
        End Function
    End Class

End Namespace

