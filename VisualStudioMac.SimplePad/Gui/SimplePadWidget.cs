using Xwt;

namespace VisualStudioMac.SimplePad.Gui
{
    public partial class SimplePadWidget : Widget
    {
        public SimplePadWidget()
        {
            Build();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
            base.Dispose(disposing);
        }
    }
}