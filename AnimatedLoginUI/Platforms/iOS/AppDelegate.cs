using Foundation;
using UIKit;

namespace AnimatedLoginUI;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
        // Esto evitará que la pantalla se bloquee mientras la app está en uso.
        UIApplication.SharedApplication.IdleTimerDisabled = true;

        return base.FinishedLaunching(app, options);
    }

}

