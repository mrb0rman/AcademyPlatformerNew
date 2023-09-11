using UnityEngine;

namespace AcademyPlatformerNew.UI.UIService
{
    public interface IUIRoot
    {
        Transform ActiveContainer { get; }
        Transform DeactiveContainer { get; }
    }
}