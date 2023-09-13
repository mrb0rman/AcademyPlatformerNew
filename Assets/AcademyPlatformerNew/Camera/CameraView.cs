using UnityEngine;

namespace AcademyPlatformerNew.Camera
{
    public class CameraView : MonoBehaviour
    {
        public UnityEngine.Camera MainCamera => mainCamera;
    
        [SerializeField] private  UnityEngine.Camera mainCamera;
    }
}