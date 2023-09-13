using AcademyPlatformerNew.Player;
using AcademyPlatformerNew.Sounds;
using AcademyPlatformerNew.UI.HUD;
using UnityEngine;
using Zenject;

namespace AcademyPlatformerNew.Protocol
{
    public class PlayerControllerProtocol
    {
        [Inject]
        public PlayerAnimator PlayerAnimator;
        [Inject]
        public PlayerHpController PlayerHpController;
        [Inject]
        public PlayerMovementController PlayerMovementController;

        [Inject] public HUDWindowController HUDWindowController;
        
        public SoundController SoundController;
        public InputController InputController;
        public PlayerConfig PlayerConfig;
        public PlayerView PlayerView;
        public PlayerView.Factory PlayerViewFactory;
        public UnityEngine.Camera Camera;
        
        public PlayerControllerProtocol( InputController inputController,
            HUDWindowController hudWindowController,
            UnityEngine.Camera camera,
            SoundController soundController,
            PlayerView.Factory playerViewFactory,
            PlayerConfig playerConfig)
        {
            SoundController = soundController;
            PlayerConfig = playerConfig;
            //_playerHpController = new PlayerHpController(_playerConfig.PlayerModel.Health, _soundController);
            //_playerHpController.OnHealthChanged += hudWindowController.ChangeHealthPoint;
            InputController = inputController;
            Camera = camera;
            PlayerViewFactory = playerViewFactory;
        }
    }
}