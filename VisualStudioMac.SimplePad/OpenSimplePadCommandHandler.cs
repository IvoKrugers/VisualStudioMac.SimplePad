using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;

namespace VisualStudioMac.SimplePad
{
    public class OpenSimplePadCommandHandler : CommandHandler
    {
        protected override void Run()
        {
            var pad = IdeApp.Workbench.GetPad<Gui.SimplePad>();
            if (pad != null)
            {
                pad.Visible = true;
                pad.IsOpenedAutomatically = true;
                pad.BringToFront(true);
            }
        }

        protected override void Update(CommandInfo info)
        {
            info.Enabled = true;
        }
    }
}