using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioOnMove : MonoBehaviour
{
    public AudioSource AudioSource;
    public string compareTag;

    private Transform attachTransform;
    private Rigidbody other;

    //TODO: Передалать на Паузу
   private void FixedUpdate()
    {
        if(other is null) return;
        print(other.velocity.magnitude);
        if (other.velocity.magnitude < 0.015f) return;
        AudioSource.Play();
        attachTransform = other.gameObject.transform;
    }


    private void OnCollisionEnter(Collision other)
    {
        if(!other.gameObject.CompareTag(compareTag)) return;
        this.other = other.rigidbody;
    }

    private void OnCollisionExit(Collision other)
    {
        this.other = null;
    }
}
