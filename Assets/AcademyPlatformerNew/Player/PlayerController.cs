using System;
using AcademyPlatformerNew.Protocol;
using AcademyPlatformerNew.Sounds;
using DG.Tweening;
using Object = UnityEngine.Object;

namespace AcademyPlatformerNew.Player
{
    public class PlayerController
    {
        public Action OnDisposed;
        
        public event Action<float> OnChangeSpeed;
         
        public const float DelayDestroyPlayer = 2f;
        
        private PlayerControllerProtocol _playerControllerProtocol;
        
        private float _currentHealth;
        private float _currentSpeed;

        public PlayerController(PlayerControllerProtocol playerControllerProtocol)
        {
            _playerControllerProtocol = playerControllerProtocol;
            
            //_playerHpController = new PlayerHpController(_playerConfig.PlayerModel.Health, _soundController);
            _playerControllerProtocol.PlayerHpController.OnHealthChanged += 
                _playerControllerProtocol.HUDWindowController.ChangeHealthPoint;
        }
        
        public PlayerView Spawn()
        {
            var model = _playerControllerProtocol.PlayerConfig.PlayerModel;
            _currentHealth = model.Health;
            _currentSpeed = model.Speed;
            _playerControllerProtocol.PlayerView = _playerControllerProtocol.PlayerViewFactory.Create();
            _playerControllerProtocol.PlayerView .SpriteRenderer.sprite = model.Sprite;

            //_playerAnimator = new PlayerAnimator(_playerView, _camera);
            _playerControllerProtocol.PlayerAnimator.Spawn();
            
            //_playerMovementController = new PlayerMovementController(_inputController, _playerView, this);
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

            _playerControllerProtocol.PlayerAnimator.Death(setEndWindow);
            
            Object.Destroy(_playerControllerProtocol.PlayerView.gameObject, DelayDestroyPlayer);
            _playerControllerProtocol.PlayerView = null;
        }
    }
}