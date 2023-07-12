using System;
using UnityEngine;

namespace VFX
{
    public class PlayByPatternOnEnter : MonoBehaviour
    {
        [SerializeField]
        private DeleteAfterPlay _particles;

        [SerializeField] 
        private string _compareTag;
        
        private void OnCollisionEnter(Collision other)
        {
            if (_compareTag is null || other.gameObject.CompareTag(_compareTag))
            {
                var collisionPoints = other.contacts;

                foreach (var collisionPoint in collisionPoints)
                {
                    var startVector = collisionPoint.point;
                    Instantiate(_particles.gameObject, startVector, Quaternion.identity);
                }
            }
        }
    }
}
