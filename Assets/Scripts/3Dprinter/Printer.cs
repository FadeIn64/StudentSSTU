using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace _3Dprinter
{
    public class Printer : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> _gameObjects;

        private GameObject _curObj;

        // Start is called before the first frame update
        void Start()
        {
            foreach (var gameObject in _gameObjects)
                gameObject.SetActive(false);
            _curObj = GetObject();
            _curObj.SetActive(true);
        }

        public void ChangeObject()
        {
            _curObj.SetActive(false);
            _curObj = GetObject();
            _curObj.SetActive(true);
        }

        private GameObject GetObject()
        {
            var random = new Unity.Mathematics.Random(435423423);
            return _gameObjects[random.NextInt(0,_gameObjects.Count-1)];
        }
    }
}
