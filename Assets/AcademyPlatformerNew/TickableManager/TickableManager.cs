using System;
using Zenject;

namespace AcademyPlatformerNew.TickableManager
{
    public class TickableManager : ITickable
    {
        public static event Action UpdateNotify;
        
        public void Tick()
        {
            UpdateNotify?.Invoke();
        }
    }
}