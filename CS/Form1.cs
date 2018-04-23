using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace ChartItemsKeyValueColorizer {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap() {
            // Create a map control with initial settings and add it to the form.
            MapControl map = new MapControl() { Dock = DockStyle.Fill };
            this.Controls.Add(map);

            //Create a tiles layer and add it to the Map control.
            map.Layers.Add(new ImageTilesLayer() {
                DataProvider = new OpenStreetMapDataProvider()
            });
            
            // Create a vector items layer and add it to the Map control.
            VectorItemsLayer itemsLayer = new VectorItemsLayer() {
                Data = CreateData(),
                Colorizer = CreateColorizer() 
            };
            map.Layers.Add(itemsLayer);

            // Create a legend.
            map.Legends.Add(new ColorListLegend() { Layer = itemsLayer });
        }

        private MapDataAdapterBase CreateData() {
            MapItemStorage storage = new MapItemStorage();
            
            // Create bubble charts and add them to the storage.
            storage.Items.Add(new MapBubble() { Argument = "A", Value = 100, 
                Location = new GeoPoint(-50, -70), Size = 100 
            });
            storage.Items.Add(new MapBubble() { Argument = "B", Value = 70, 
                Location = new GeoPoint(-50, 0), Size = 70 
            });
            storage.Items.Add(new MapBubble() { Argument = "C", Value = 120, 
                Location = new GeoPoint(-50, 70), Size = 120 
            });
            
            //Create a pie chart and add it to the storage.
            MapPie pie = new MapPie() { Location = new GeoPoint(30, 0), Size = 100 };
            pie.Segments.Add(new PieSegment() { Argument = "A", Value = 100 });
            pie.Segments.Add(new PieSegment() { Argument = "B", Value = 50 });
            pie.Segments.Add(new PieSegment() { Argument = "C", Value = 120 });
            storage.Items.Add(pie);

            return storage;
        }

        private MapColorizer CreateColorizer() {
            KeyValueColorizer colorizer = new KeyValueColorizer() {
                ColorItemKeyProvider = new ChartItemArgumentToColorKeyProvider()
            };
            colorizer.AddItem("A", new ColorizerColorTextItem(Color.Coral, "Argument A"));
            colorizer.AddItem("B", new ColorizerColorTextItem(Color.Orange, "Argument B"));
            colorizer.AddItem("C", new ColorizerColorTextItem(Color.LightBlue, "Argument C"));

            return colorizer;
        }
    }

}

