using AcademyPlatformerNew.Protocol;
using AcademyPlatformerNew.UI.UIService;
using AcademyPlatformerNew.UI.UIWindow;

namespace AcademyPlatformerNew
{
    public class GameController
    {
        private readonly UIService _uiService;

        public GameController(UIService uiService)
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