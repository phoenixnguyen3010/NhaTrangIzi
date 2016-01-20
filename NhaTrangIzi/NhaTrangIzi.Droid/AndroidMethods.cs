using NhaTrangIzi.Droid;
using NhaTrangIzi.interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidMethods))]
namespace NhaTrangIzi.Droid
{
    public class AndroidMethods : IAndroidMethods
    {
        public void CloseApp()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}