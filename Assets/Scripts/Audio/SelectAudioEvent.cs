using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAudioEvent : MonoBehaviour
{

    [SerializeField]
    private AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
        AudioSource.Play();
    }
}
