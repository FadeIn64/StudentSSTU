using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AudioScript : MonoBehaviour
{

    [SerializeField]
    private AudioSource AudioSource;

    [FormerlySerializedAs("tag")] [SerializeField]
    private string handleTag;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(handleTag))
        {
            AudioSource.Play();
            print("Collision detected");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(handleTag))
        {
           AudioSource.Play();
            print("Collision detected");
        }
    }
}
