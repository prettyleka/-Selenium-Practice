using SelemniumProject.Infra.Components;
using SelemniumProject.Infra.Components;

namespace SelemniumProject.PagesAndObj.Pages
{

    public class BasePage
    {
        #region Properties
        public ToolMenu toolMenu
        {
            get
            {
                return new ToolMenu();
            }
        }

        public DocDownloads docDownloads
        {
            get
            {
                return new DocDownloads();
            }
        }
        #endregion
    }
}
