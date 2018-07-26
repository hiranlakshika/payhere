
using Android.App;
using Android.OS;
using Android.Webkit;

namespace PayHere.Droid.Screens
{
    [Activity(Label = "WebViewActivity")]
    public class WebViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.webview);

            WebView webView = FindViewById<WebView>(Resource.Id.webView1);
            webView.Settings.JavaScriptEnabled = true;
            webView.SetWebChromeClient(new WebChromeClient());
            webView.Settings.DomStorageEnabled = true;
            webView.LoadUrl("file:///android_asset/payweb.html");
        }
    }
}