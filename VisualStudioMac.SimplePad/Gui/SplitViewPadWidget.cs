using Xwt;
using Xwt.Drawing;

namespace VisualStudioMac.SimplePad.Gui
{
    public partial class SplitViewPadWidget : Widget
    {
        public SplitViewPadWidget()
        {
            //CanGetFocus = true;

            var paned = new VPaned() { ExpandHorizontal = true, ExpandVertical=true};
            paned.Panel1.Content = new VBox() { BackgroundColor = Colors.CornflowerBlue, MinHeight = 100 };
            paned.Panel2.Content = new VBox() { BackgroundColor = Colors.DarkOliveGreen, MinHeight = 100 };

            Content = paned;
        }
    }
}

