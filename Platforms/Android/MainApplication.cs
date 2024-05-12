using Android.App;
using Android.Content.Res;
using Android.Runtime;

namespace Notebook
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
            
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
                if (view is Entry )
                {
                   


                    // Change placeholder text color
                    handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
                    handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
                    
                }
            });

        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
