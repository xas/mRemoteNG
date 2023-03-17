using System.Windows.Forms;
using System.ComponentModel;

namespace mRemoteNG.UI.Menu.msExternalTools
{
    public partial class externalToolsMenu : ToolStripMenuItem
    {
        public externalToolsMenu()
        {
            Initialize();
        }

        public externalToolsMenu(IContainer container)
        {
            container.Add(this);

            Initialize();
        }

        private void Initialize()
        {
        }
    }
}
