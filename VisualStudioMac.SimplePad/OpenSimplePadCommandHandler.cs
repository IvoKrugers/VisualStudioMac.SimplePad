using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;

namespace VisualStudioMac.SimplePad
{
    public class OpenSimplePadCommandHandler : CommandHandler
    {
        protected override void Run()
        {
            OpenPad<Gui.SimplePad>();
            OpenPad<Gui.SplitViewPad>();
        }

        protected override void Update(CommandInfo info)
        {
            info.Enabled = true;
        }

        private void OpenPad<T>()
        {
            var pad = IdeApp.Workbench.GetPad<T>();
            if (pad != null)
            {
                pad.Visible = true;
                pad.IsOpenedAutomatically = true;
                pad.BringToFront(true);
            }
        }
    }
}