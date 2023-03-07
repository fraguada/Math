using System;
using Microsoft.Maui.Handlers;
using OpenGLView = MauiMathApp.Controls.OpenGLView;

namespace MauiMathApp.Handlers
{
    public partial class OpenGLViewHandler
	{
        public static PropertyMapper<OpenGLView, OpenGLViewHandler> PropertyMapper = new(ViewMapper)
        {
            //[nameof(OpenGLView.MyProperty)] = MapMyProperty,
        };

        public static CommandMapper<OpenGLView, OpenGLViewHandler> CommandMapper = new(ViewCommandMapper)
        {
            //[nameof(OpenGLView.MyCommand)] = MapMyCommand,
        };

        public OpenGLViewHandler() : base(PropertyMapper, CommandMapper)
        {
        }
	}
}

