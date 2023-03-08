using System;
using Android.Opengl;
using Javax.Microedition.Khronos.Opengles;
using Microsoft.Maui.Handlers;
using GL = Android.Opengl.GLES30;
using OpenGLView = MauiMathApp.Controls.OpenGLView;
#nullable enable

namespace MauiMathApp.Handlers
{
    class MyGLRenderer : Java.Lang.Object, GLSurfaceView.IRenderer
    {

        public void OnDrawFrame(IGL10? gl)
        {
            GL.GlClear((int)GL.GlColorBufferBit);
            GL.GlClearColor(0, 0, 1, 1);
        }

        public void OnSurfaceChanged(IGL10? gl, int width, int height)
        {
            GL.GlViewport(0, 0, width, height);

        }

        public void OnSurfaceCreated(IGL10? gl, Javax.Microedition.Khronos.Egl.EGLConfig? config)
        {
            GL.GlClearColor(0.0f, 0.0f, 0.0f, 1.0f);
        }
    }

    partial class OpenGLViewHandler : ViewHandler<OpenGLView, GLSurfaceView>
    {
        protected override GLSurfaceView CreatePlatformView() => new GLSurfaceView(Context);

        protected override void ConnectHandler(GLSurfaceView platformView)
        {
            base.ConnectHandler(platformView);
            var renderer = new MyGLRenderer();
            platformView.SetRenderer(renderer);
        }
    }
}

