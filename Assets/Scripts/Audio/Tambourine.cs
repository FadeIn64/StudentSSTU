using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Audio
{
    [RequireComponent( typeof(AudioSource))]
    public class Tambourine : MonoBehaviour
    {
        private AudioSource _audioSource;

        private Vector3 _prevPosition;
        private Transform _tr;
        
        [SerializeField]
        private float _velocityOffset;
        // Start is called before the first frame update
        void Start()
        {
            _audioSource = GetComponent<AudioSource>();
            _audioSource.Pause();
            _tr = transform;
            _prevPosition = _tr.position;
        }

        private void Update()
        {
            var velocity = _prevPosition - _tr.position;
            var magnitude = velocity.magnitude / Time.deltaTime;
            if (magnitude > _velocityOffset)
            {
                if (_audioSource.isPlaying) return;
                print("BBBBBBBBBB");
                _audioSource.Play();
            }
            else if(_audioSource.isPlaying)
            {
                print("SSSSSSSSSS");
                _audioSource.Stop();
            }

            _prevPosition = _tr.position;
        }
    }
}
