using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _3Dprinter
{
    [RequireComponent(typeof(ParticleSystem))]
    public class Particle_Smoke : MonoBehaviour
    {
        [SerializeField]
        Printer printer;
        [SerializeField]
        ParticleSystem particleSystem;
        // Start is called before the first frame update
        void Start()
        {
            particleSystem = GetComponent<ParticleSystem>();
            printer.OnChangeEvent += particleSystem.Play;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}