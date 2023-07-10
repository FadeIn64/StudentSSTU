using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
public class ParticalScript : MonoBehaviour
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
            _system.Play();
            print("Collision detected");
        }
    }
}
