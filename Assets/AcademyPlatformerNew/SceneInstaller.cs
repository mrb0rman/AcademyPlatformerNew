using AcademyPlatformerNew.Installer;
using Zenject;

namespace AcademyPlatformerNew
{
    public class SceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            UIServicenstaller.Install(Container);
            
            PlayerInstaller.Install(Container);
            
            FallObjectInstaller.Install(Container);
        }
    }
}