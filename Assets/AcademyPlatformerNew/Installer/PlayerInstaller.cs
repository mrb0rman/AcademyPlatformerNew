using AcademyPlatformerNew.Player;
using Zenject;

namespace AcademyPlatformerNew.Installer
{
    public class PlayerInstaller : Installer<PlayerInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .BindFactory<PlayerView, PlayerView.Factory>()
                .FromComponentInNewPrefabResource(ResourcesConst.PlayerPrefab)
                .AsSingle();
            
            Container
                .Bind<PlayerConfig>()
                .FromScriptableObjectResource(ResourcesConst.PlayerConfig)
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<PlayerAnimator>()
                .AsSingle()
                .NonLazy();

            Container
                .Bind<PlayerMovementController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<PlayerController>()
                .AsSingle()
                .NonLazy();
        }
    }
}