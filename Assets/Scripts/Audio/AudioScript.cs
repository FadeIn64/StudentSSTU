using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    [SerializeField]
    private AudioSource AudioSource;

    [SerializeField]
    private string tag;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tag))
        {
            AudioSource.Play();
            print("Collision detected");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag(tag))
        //{
        //    AudioSource.Play();
        //    print("Collision detected");
        //}
    }
}
