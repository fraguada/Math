using Microsoft.Maui.Handlers;
using OpenGLView = MauiMathApp.Controls.OpenGLView;
#nullable enable

namespace MauiMathApp.Handlers
{
  partial class OpenGLViewHandler : ViewHandler<OpenGLView, Microsoft.UI.Xaml.Controls.UserControl>
  {
    protected override Microsoft.UI.Xaml.Controls.UserControl CreatePlatformView() => new Microsoft.UI.Xaml.Controls.UserControl();

    protected override void ConnectHandler(Microsoft.UI.Xaml.Controls.UserControl platformView)
    {
      base.ConnectHandler(platformView);
    }
  }
}

