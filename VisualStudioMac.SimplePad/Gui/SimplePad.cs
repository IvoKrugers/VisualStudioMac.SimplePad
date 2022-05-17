using AppKit;
using MonoDevelop.Components;
using MonoDevelop.Ide.Gui;

namespace VisualStudioMac.SimplePad.Gui
{
    public class SimplePad : PadContent
    {
        private FilterPadWidget widget;
        private Control control;

        public override Control Control
        {
            get
            {
                if (control == null)
                {
                    widget = new FilterPadWidget();
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