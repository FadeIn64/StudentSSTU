using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioOnMove : MonoBehaviour
{
    public AudioSource AudioSource;
    public string compareTag;
    public float magnitudeTrigger;
    
    private Rigidbody other;

    private void FixedUpdate()
    {
        if(other is null) return;
        if (other.velocity.magnitude > magnitudeTrigger && !AudioSource.isPlaying)
        {
            AudioSource.UnPause();
            return;
        }
        AudioSource.Pause();
    }


    private void OnCollisionEnter(Collision other)
    {
        if(!other.gameObject.CompareTag(compareTag)) return;
        this.other = other.rigidbody;
        AudioSource.Play();
    }

    private void OnCollisionExit(Collision other)
    {
        this.other = null;
        AudioSource.Stop();
    }
}
