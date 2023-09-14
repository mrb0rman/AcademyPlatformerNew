using AcademyPlatformerNew.Camera;
using AcademyPlatformerNew.Player;
using AcademyPlatformerNew.Sounds;
using AcademyPlatformerNew.UI.HUD;
using UnityEngine;
using Zenject;

namespace AcademyPlatformerNew.Protocol
{
    public class PlayerControllerProtocol
    {
        public HUDWindowController HUDWindowController;
        public SoundController SoundController;
        public InputController InputController;
        public PlayerConfig PlayerConfig;
        public PlayerView PlayerView;
        public PlayerView.Factory PlayerViewFactory;
        public CameraView Camera;
        
        public PlayerControllerProtocol(InputController inputController,
            HUDWindowController hudWindowController,
            CameraView camera,
            SoundController soundController,
            PlayerView.Factory playerViewFactory,
            PlayerConfig playerConfig)
        {
            HUDWindowController = hudWindowController;
            SoundController = soundController;
            PlayerConfig = playerConfig;
            InputController = inputController;
            Camera = camera;
            PlayerViewFactory = playerViewFactory;
        }
    }
}