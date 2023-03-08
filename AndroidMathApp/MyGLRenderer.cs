using System;
using Android.Content;
using Android.Opengl;
using Android.Util;
using Java.Lang;
using Javax.Microedition.Khronos.Opengles;
using GL = Android.Opengl.GLES30;

namespace AndroidMathApp
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


}