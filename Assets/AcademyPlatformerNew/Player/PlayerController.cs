using System;
using AcademyPlatformerNew.Protocol;
using DG.Tweening;
using Sounds;
using Object = UnityEngine.Object;

namespace AcademyPlatformerNew.Player
{
    public class PlayerController
    {
        public Action OnDisposed;
        
        public event Action<float> OnChangeSpeed;
        public PlayerHpController PlayerHpController => _playerHpController;
        
        public const float DelayDestroyPlayer = 2f;
        
        private PlayerHpController _playerHpController;
        private PlayerControllerProtocol _playerControllerProtocol;
        private PlayerAnimator _playerAnimator;
        private PlayerMovementController _playerMovementController;
        
        private float _currentHealth;
        private float _currentSpeed;

        public PlayerController(PlayerControllerProtocol playerControllerProtocol)
        {
            _playerControllerProtocol = playerControllerProtocol;
            
            _playerHpController = 
                new PlayerHpController(_playerControllerProtocol.PlayerConfig.PlayerModel.Health, _playerControllerProtocol.SoundController);
            _playerHpController.OnHealthChanged += 
                _playerControllerProtocol.HUDWindowController.ChangeHealthPoint;
        }
        
        public PlayerView Spawn()
        {
            var model = _playerControllerProtocol.PlayerConfig.PlayerModel;
            _currentHealth = model.Health;
            _currentSpeed = model.Speed;
            _playerControllerProtocol.PlayerView = _playerControllerProtocol.PlayerViewFactory.Create();
            _playerControllerProtocol.PlayerView .SpriteRenderer.sprite = model.Sprite;

            _playerAnimator = new PlayerAnimator(_playerControllerProtocol.PlayerView, _playerControllerProtocol.Camera);
            _playerAnimator.Spawn();
            
            _playerMovementController = new PlayerMovementController(_playerControllerProtocol.InputController, 
                _playerControllerProtocol.PlayerView, 
                this, 
                _playerControllerProtocol.PlayerConfig);
            
            return _playerControllerProtocol.PlayerView;
        }

        public void SetSpeed(float newSpeed)
        {
            _currentSpeed = newSpeed;

            OnChangeSpeed?.Invoke(_currentSpeed);
        }

        public void DestroyView(TweenCallback setEndWindow = null)
        {
            OnDisposed?.Invoke();
            
            _playerControllerProtocol.SoundController.Stop();
            _playerControllerProtocol.SoundController.Play(SoundName.GameOver);

            _playerAnimator.Death(setEndWindow);
            
            Object.Destroy(_playerControllerProtocol.PlayerView.gameObject, DelayDestroyPlayer);
            _playerControllerProtocol.PlayerView = null;
        }
    }
}