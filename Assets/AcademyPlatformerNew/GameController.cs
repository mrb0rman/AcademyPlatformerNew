using AcademyPlatformerNew.Protocol;
using AcademyPlatformerNew.UI.UIService;
using AcademyPlatformerNew.UI.UIWindow;

namespace AcademyPlatformerNew
{
    public class GameController
    {
        private readonly IUIService _uiService;

        public GameController(IUIService uiService)
        {
            _uiService = uiService;
            
            Init();
        }

        private void Init()
        {
            _uiService.Show<UIMainMenuWindow>();
        }
    }
}