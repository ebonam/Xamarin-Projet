using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XamarinFinal.Vue.ACTION
{
    public class MapPage : Xamarin.Forms.Maps.Map
    {
        public List<Position> RouteCoordinates { get; set; }
        public List<CustomPin> CustomPins { get; internal set; }

        public MapPage()
        {
            RouteCoordinates = new List<Position>();
         

        }

    }
}