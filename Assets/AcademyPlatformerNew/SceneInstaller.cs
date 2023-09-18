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
            
            Container
                .BindInterfacesTo<GameController>()
                .AsSingle()
                .NonLazy();
            
            SoundInstaller.Install(Container);
            
            Container
                .BindInterfacesAndSelfTo<InputController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<PlayerControllerProtocol>()
                .AsSingle()
                .NonLazy();
            
            UIServiceInstaller.Install(Container);
            
            

            PlayerInstaller.Install(Container);

            FallObjectInstaller.Install(Container);
        }
    }
}