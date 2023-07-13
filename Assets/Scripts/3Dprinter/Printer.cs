using System.Collections.Generic;
using UnityEngine;

namespace _3Dprinter
{
    public class Printer : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> _gameObjects;

        private GameObject _curObj;
        private int _index = 0;

        internal delegate void OnChangeObject();

        internal event OnChangeObject OnChangeEvent; 

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
            OnChangeEvent?.Invoke();
            _curObj.SetActive(true);
        }

        private GameObject GetObject()
        {
            _index++;
            _index = (_index >= _gameObjects.Count) ? 0 : _index;
            return _gameObjects[_index];
        }
    }
}
