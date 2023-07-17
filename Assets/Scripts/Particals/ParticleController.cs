using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public Transform destructionPoint;

    private void Update()
    {
        // ѕровер€ем положение частиц и отключаем систему частиц, если они достигли destructionPoint
        if (particleSystem.transform.position == destructionPoint.position)
        {
            particleSystem.Stop();
        }
        print("stop");   
    }
}
