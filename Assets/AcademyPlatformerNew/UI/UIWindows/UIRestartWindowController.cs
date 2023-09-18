using AcademyPlatformerNew;

namespace UI.UIWindows
{
    public class UIRestartWindowController
    {
        private readonly UIService.UIService _uiService;
       
        private UIRestartWindow _restartWindow;
        private GameController _gameController;
        public UIRestartWindowController(UIService.UIService uiService, GameController gameController)
        {
            _uiService = uiService;
            _gameController = gameController;
            _restartWindow = uiService.Get<UIRestartWindow>();

           
            _restartWindow.OnShowEvent += ShowWindow;
            _restartWindow.OnHideEvent += HideWindow;
        }

        private void ShowWindow()
        {
            _restartWindow.OnReturnButtonClickEvent += ShowGameWindows;
            _restartWindow.OnReturnButtonClickEvent += _gameController.StartGame;
        }
        private void HideWindow()
        {
            _restartWindow.OnReturnButtonClickEvent -= ShowGameWindows;
            _restartWindow.OnReturnButtonClickEvent -= _gameController.StartGame;
        }

        public void ShowGameWindows()
        {
            _uiService.Hide<UIRestartWindow>();
            _uiService.Show<UIGameWindow>();
        }
    }
}