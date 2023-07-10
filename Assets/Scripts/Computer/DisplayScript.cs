using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

namespace Computer
{
    public class DisplayScript : MonoBehaviour
    {
        [SerializeField] 
        private XRSimpleInteractable _zeroButton;
        [SerializeField] 
        private XRSimpleInteractable _oneButton;
        [SerializeField] 
        private Text _text;
        // Start is called before the first frame update
        void Start()
        {
            _text.text = "";
            _zeroButton.selectEntered.AddListener(ChangeTextPlusZero);
            _oneButton.selectEntered.AddListener(ChangeTextTPlusOne);
        }

        private void ChangeTextPlusZero(SelectEnterEventArgs selectEnterEventArgs)
        {
            _text.text = "0" + _text.text;
        }
        private void ChangeTextTPlusOne(SelectEnterEventArgs selectEnterEventArgs)
        {
            _text.text = "1" + _text.text;
        }
    }
}