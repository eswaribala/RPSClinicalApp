using Android.App;
using Android.Net.Wifi;
using RPSClinicalApp;
using RPSClinicalApp.Helpers;
using System.Net;
using Xamarin.Forms;

[assembly: Dependency(typeof(NetService))]
namespace RPSClinicalApp
{
    public class NetService : INetService
    {
        public string ConvertHostIP()
        {
            WifiManager wifiManager = (WifiManager)Android.App.Application.Context.GetSystemService(Service.WifiService);
            int ip = wifiManager.ConnectionInfo.IpAddress;
            IPAddress ipAddr = new IPAddress(ip);

            //  System.out.println(host);
            return ipAddr.ToString();
        }
    }
}