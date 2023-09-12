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
                .Bind<GameController>()
                .AsSingle()
                .NonLazy();
            
            UIServiceInstaller.Install(Container);
            
            
            //PlayerInstaller.Install(Container);
            
            //FallObjectInstaller.Install(Container);
        }
    }
}