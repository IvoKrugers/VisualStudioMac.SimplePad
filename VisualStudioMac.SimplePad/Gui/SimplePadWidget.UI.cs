using Xwt;
using Xwt.Drawing;

namespace VisualStudioMac.SimplePad.Gui
{
    public partial class FilterPadWidget : Widget
    {
        protected virtual void Build()
        {
            CanGetFocus = true;

            var label = new Label("This is the simple pad.")
            {
                BackgroundColor = Colors.Red
            };

            var mainFrame = new FrameBox(label)
            {
                MinHeight = 130,
                BackgroundColor = Colors.Black
            };

            Content = mainFrame;
        }
    }
}