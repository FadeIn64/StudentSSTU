using UnityEngine;

namespace Computer
{
    public class Beatle : MonoBehaviour
    {
        private bool _isSleep;
        // Start is called before the first frame update
        void Start()
        {
            _isSleep = true;
            gameObject.SetActive(!_isSleep);
        }

        public void WakeUp()
        {
            _isSleep = true;
            gameObject.SetActive(_isSleep);
        }

        public void Sleep()
        {
            _isSleep = false;
            gameObject.SetActive(_isSleep);
        }
    }
}
