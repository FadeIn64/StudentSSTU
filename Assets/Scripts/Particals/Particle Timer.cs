using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTimer : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public float activationFrequency = 1f; // Частота активации в секундах
    private float timer;

    private void Start()
    {
        timer = activationFrequency;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            ActivateParticleSystem();
            timer = activationFrequency;
        }
    }

    private void ActivateParticleSystem()
    {
        particleSystem.Play();
    }
}
