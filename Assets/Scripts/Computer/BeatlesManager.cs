using System.Collections.Generic;
using UnityEngine;
using Random = Unity.Mathematics.Random;

namespace Computer
{
    public class BeatlesManager : MonoBehaviour
    {
        private List<Beatle> _beatles;
        private int _framesCount;
        private Random _random;
        
        void Start()
        {
            _beatles = new List<Beatle>(GetComponentsInChildren<Beatle>(true));
            _random = new Random(3234242332);
        }

        private void FixedUpdate()
        {
            ++_framesCount;
            if (_framesCount / 100 == _random.NextInt(1,3))
                WakeUp();
        }

        public void WakeUp()
        {
            foreach (var beatle in _beatles)
                beatle.WakeUp();
        }

        public void Sleep()
        {
            foreach (var beatle in _beatles)
                beatle.Sleep();
        }
    }
}
