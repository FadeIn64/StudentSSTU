using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ParticleStop : MonoBehaviour
{
    [FormerlySerializedAs("tag")]
    [SerializeField]
    private string _tag;
    [SerializeField]
    private ParticleSystem _system;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(_tag))
        {
            _system.Stop();
            print("Collision detected");
        }
    }
}
