using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    [SerializeField]
    private AudioSource AudioSource;

    void Start()
    {
        
    }
    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Computer"))
        {
            AudioSource.Play();
            print("Collision detected");
        }
    }
}
