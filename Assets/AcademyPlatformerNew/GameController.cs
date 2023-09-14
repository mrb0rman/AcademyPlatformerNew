using AcademyPlatformerNew.Player;
using AcademyPlatformerNew.Protocol;
using AcademyPlatformerNew.UI.UIService;
using AcademyPlatformerNew.UI.UIWindow;

namespace AcademyPlatformerNew
{
    public class GameController
    {
        private readonly IUIService _uiService;
        private readonly PlayerController _playerController;

        public GameController(IUIService uiService, PlayerController playerController)
        {
            _uiService = uiService;
            _playerController = playerController;

            Init();
        }

        private void Init()
        {
            _uiService.Show<UIMainMenuWindow>();
            _playerController.Spawn();
        }
    }
}