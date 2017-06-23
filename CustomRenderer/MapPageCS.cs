using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using XamarinFinal.Vue.ACTION;
namespace XamarinFinal {
    public class MapPageCS2 : ContentPage
    {
        public MapPageCS2()
        {
            var customMap = new MapPage
            {
                MapType = MapType.Street,
                WidthRequest = 400,
                HeightRequest = 400
            };
            customMap.RouteCoordinates.Add(new Position(37.785559, -122.396728));
            customMap.RouteCoordinates.Add(new Position(37.780624, -122.390541));
            customMap.RouteCoordinates.Add(new Position(37.777113, -122.394983));
            customMap.RouteCoordinates.Add(new Position(37.776831, -122.394627));

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Xamarin.Forms.Maps.Distance.FromMiles(10.0)));


            var pin = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(37.79752, -122.40183),
                    Label = "Xamarin San Francisco Office",
                    Address = "394 Pacific Ave, San Francisco CA"
                },
                Id = "Xamarin",

            };
            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin.Pin);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(
              new Position(37.79752, -122.40183), Xamarin.Forms.Maps.Distance.FromMiles(1.0)));

            Button Bouton = new Button();
            Bouton.Clicked += quit;
            Bouton.Text = "Quitter";
            StackLayout d = new StackLayout () { Children = { customMap, Bouton } };

            Content = d;
        }

        private void quit(object sender, EventArgs e)
        {
            App.Instance.ToMenu();
        }

        public MapPageCS2(List<string> s, string debut, string fin)
        {
            var customMap = new MapPage
            {
                MapType = MapType.Street,
                WidthRequest = 400,
                HeightRequest = 400
            };

            List<CustomPin> cp = new List<CustomPin>();
            foreach (string str in s)
            {
                CustomPin cps;
                LatLon l = Geocoding.GetLatLon(str);
                Position p = new Xamarin.Forms.Maps.Position(l.lat, l.lon);
                if (fin == str)
                {

                    cps = new CustomPin
                    {
                        Pin = new Pin
                        {
                            Type = PinType.Place,
                            Position = p,
                            Label = "Arrivé",
                            Address = str
                        },
                        Id = str,

                    };
                   


                }
                else if (debut == str)
                {
                    cps=new CustomPin
                    {
                        Pin = new Pin
                        {
                            Type = PinType.Place,
                            Position = p,
                            Label = "Depart",
                            Address = str
                        },
                        Id = str,

                    }
                    ;


                }
                else
                {
                    cps=new CustomPin
                    {
                        Pin = new Pin
                        {
                            Type = PinType.Place,
                            Position = p,
                            Label = "Etape",
                            Address = str
                        },
                        Id = str,

                    }
                        ;
                }
                customMap.Pins.Add(cps.Pin);

            }
            customMap.CustomPins = cp;
            LatLon l1 = Geocoding.GetLatLon(debut);
            Position p1 = new Xamarin.Forms.Maps.Position(l1.lat, l1.lon);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(p1, Xamarin.Forms.Maps.Distance.FromMiles(10.0)));



            Button Bouton = new Button();
            Bouton.Clicked += quit;
            Bouton.Text = "Quitter";
            StackLayout d = new StackLayout() { Children = { customMap, Bouton } };

            Content = d;
        }


    }
}