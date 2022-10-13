using System;
using System.Reflection;
using AppKit;
using MonoDevelop.Components;
using MonoDevelop.Ide.Gui;

namespace VisualStudioMac.SimplePad.Gui
{
    public class SplitViewPad : PadContent
    {
        private SplitViewPadWidget widget;
        private Control control;

        public override Control Control
        {
            get
            {
                if (control == null)
                {
                    widget = new SplitViewPadWidget();
                    control = new XwtControl(widget);
                }
                // Returning control does not work.
                return control.GetNativeWidget<NSView>();
            }
        }

        public override void Dispose()
        {
            if (widget != null)
            {
                widget.Dispose();
                widget = null;
            }
            base.Dispose();
        }
    }
}