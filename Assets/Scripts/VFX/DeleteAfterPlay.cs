using UnityEngine;

namespace VFX
{
    public class DeleteAfterPlay : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem _particleSystem;
        // Start is called before the first frame update
        void Start()
        {
            if (_particleSystem is null)
                _particleSystem = GetComponent<ParticleSystem>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (_particleSystem.isPlaying)
                return;
            Destroy(gameObject);
        }
    }
}
