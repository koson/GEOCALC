using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device;
using System.Device.Location;

namespace GEOCALC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(distance(32.9697, -96.80322, 29.46786, -98.53506, 'M'));
            //Console.WriteLine(distance(32.9697, -96.80322, 29.46786, -98.53506, 'K'));
            Console.WriteLine(distance(32.9697, -96.80322, 29.46786, -98.53506, 'K'));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //double latA = -31.997976f;
            //double longA = 115.762877f;
            //double latB = -31.99212f;
            //double longB = 115.763228f;

            double latA = 13.728383;
            double longA = 100.778554;
            double latB = 13.723353;
            double longB = 100.775161;
            Console.WriteLine(distance(latA, longA, latB, longB, 'K'));


            var locA = new GeoCoordinate(latA, longA);
            var locB = new GeoCoordinate(latB, longB);
            double dist = locA.GetDistanceTo(locB)/1000d; // kilo metres
            Console.WriteLine(dist);

        }


    }
}
