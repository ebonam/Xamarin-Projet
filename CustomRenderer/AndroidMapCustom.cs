using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;
using Xamarin.Forms.Platform.Android;
using XamarinFinal.Vue.ACTION;

namespace MapOverlay.Droid
{
    public class AndroidMapCustom: MapRenderer, IOnMapReadyCallback
    {
        GoogleMap map;
        List<Position> routeCoordinates;

        protected override void OnElementChanged(ElementChangedEventArgs<Map> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Unsubscribe
            }

            if (e.NewElement != null)
            {
                var formsMap = (MapPage)e.NewElement;
                routeCoordinates = formsMap.RouteCoordinates;

                ((MapView)Control).GetMapAsync(this);
            }
        }
        public void OnMapReady(GoogleMap googleMap)
        {
            map = googleMap;

            var polylineOptions = new PolylineOptions();
            polylineOptions.InvokeColor(0x66FF0000);

            foreach (var position in routeCoordinates)
            {
                polylineOptions.Add(new Android.Gms.Maps.Model.LatLng(position.Latitude, position.Longitude));
            }

            map.AddPolyline(polylineOptions);
        }


    }
}