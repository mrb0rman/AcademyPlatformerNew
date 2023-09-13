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
            UIServiceInstaller.Install(Container);
            
            Container
                .Bind<GameController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<TickableManager.TickableManager>()
                .AsSingle()
                .NonLazy();

            Container
                .Bind<InputController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<CameraView>()
                .FromComponentInNewPrefabResource(ResourcesConst.CameraPrefab)
                .AsSingle()
                .NonLazy();
            
            PlayerInstaller.Install(Container);

            //FallObjectInstaller.Install(Container);
        }
    }
}