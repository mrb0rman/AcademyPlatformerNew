using UnityEngine;
using Zenject;

namespace AcademyPlatformerNew.Sounds
{
    public class SoundView : MonoBehaviour
    {
        public AudioSource AudioSource => audioSource;

        [SerializeField] private AudioSource audioSource;

        public class Pool : MonoMemoryPool<SoundName, float, bool, SoundView>
        {
            protected override void Reinitialize(SoundName soundName, float volume, bool loop, SoundView item)
            {
                base.Reinitialize(soundName, volume, loop, item);
            }
        }
    }
}