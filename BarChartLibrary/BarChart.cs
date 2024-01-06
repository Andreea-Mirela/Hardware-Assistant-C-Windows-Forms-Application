using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarChartLibrary
{
    public partial class BarChart : UserControl
    {
        public BarChartValue[] Data { get; set; }
        List<String> listaLocala = new List<string>();
        public BarChart()
        {
            InitializeComponent();
            ResizeRedraw = true;
            

            Data = new[]
            {
                new BarChartValue("HP Inc",58800,"purple"),
                new BarChartValue("Lenovo",54857,"red"),
                new BarChartValue("Dell Inc",41821,"darkorange"),
                new BarChartValue("Apple",19551,"yellow")
            };
        }

        private void BarChart_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Rectangle rectangle = e.ClipRectangle;

            
            var scaleFactor = rectangle.Height / Data.Max(x=>x.Shipments);
            
            var barWidth = (rectangle.Width - 200) / Data.Length;
           
            var maxBarHeight = rectangle.Height * 0.9;

            for (int i = 0; i < Data.Length; i++)
            {
                var eachBarHeight = Data[i].Shipments * scaleFactor;

                graphics.FillRectangle(new SolidBrush(Color.FromName(Data[i].Color)),
                    i * barWidth, rectangle.Height - eachBarHeight, barWidth * 0.95f, eachBarHeight);

            }
            var xCoord = rectangle.Width - 220;
            var yCoord = 0;

            for (int i = 0; i < Data.Length; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.FromName(Data[i].Color)), xCoord, yCoord, 35, 35);

                graphics.DrawString(Data[i].Label +":"+ Data[i].Shipments+"produse/an", new Font("Consolas", 10),
                    new SolidBrush(Color.FromName(Data[i].Color)), xCoord + 35, yCoord + 20);

                yCoord += 35;
            }
        }
    }
    }


