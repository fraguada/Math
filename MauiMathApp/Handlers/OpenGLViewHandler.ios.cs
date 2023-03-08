using System;
using Android.Opengl;
using Javax.Microedition.Khronos.Opengles;
using Microsoft.Maui.Handlers;
using GL = Android.Opengl.GLES30;
using OpenGLView = MauiMathApp.Controls.OpenGLView;
#nullable enable

namespace MauiMathApp.Handlers
{
    partial class OpenGLViewHandler : ViewHandler<OpenGLView, NSView>
    {
        protected override NSView CreatePlatformView() => new NSView();

        protected override void ConnectHandler(NSView platformView)
        {
            base.ConnectHandler(platformView);
        }
    }
}

