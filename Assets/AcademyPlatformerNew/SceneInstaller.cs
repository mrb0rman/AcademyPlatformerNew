using AcademyPlatformerNew.Camera;
using AcademyPlatformerNew.Installer;
using AcademyPlatformerNew.Protocol;
using Zenject;

namespace AcademyPlatformerNew
{
    public class SceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<CameraView>()
                .FromComponentInNewPrefabResource(ResourcesConst.CameraPrefab)
                .AsSingle()
                .NonLazy();
            
            UIServiceInstaller.Install(Container);
            
            Container
                .Bind<GameController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .BindInterfacesAndSelfTo<TickableManager.TickableManager>()
                .AsSingle()
                .NonLazy();

            Container
                .Bind<InputController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<PlayerControllerProtocol>()
                .AsSingle()
                .NonLazy();
            
            SoundInstaller.Install(Container);

            PlayerInstaller.Install(Container);

            //FallObjectInstaller.Install(Container);
        }
    }
}