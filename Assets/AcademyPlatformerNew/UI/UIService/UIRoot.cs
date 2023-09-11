using UnityEngine;

namespace AcademyPlatformerNew.UI.UIService
{
    public class UIRoot : MonoBehaviour, IUIRoot
    {
        public Transform ActiveContainer => activateContainer;
        public Transform DeactiveContainer => deactivateContainer;

        [SerializeField] private Transform activateContainer;
        [SerializeField] private Transform deactivateContainer;
    }
}