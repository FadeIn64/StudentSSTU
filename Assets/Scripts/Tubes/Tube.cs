using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit;

namespace Tubes
{
    public class Tube : MonoBehaviour
    {
        [SerializeField] 
        private TubeCategory _category;

        [FormerlySerializedAs("_sticker")] [SerializeField] 
        private XRGrabInteractable _stickerGrabInteractable;

        private GameObject _stickerGameObject;
        private Transform _stickerTransform;
        private StartTransform _startTransform;
        private Rigidbody _stickerRigidbody;

        public delegate void OnTriggerSticker();

        public event OnTriggerSticker OnTriggerStickerEvent;

        private void Start()
        {
            _stickerGameObject = _stickerGrabInteractable.gameObject;
            _stickerGameObject.tag = "Sticker";
            _stickerTransform = _stickerGrabInteractable.transform;
            _stickerRigidbody = _stickerGameObject.GetComponent<Rigidbody>();
            _stickerRigidbody.isKinematic = true;
            _startTransform.position = _stickerTransform.position;
            _startTransform.rotation = _stickerTransform.rotation;
            
            _stickerGrabInteractable.selectExited.AddListener(ChangeKinematic);
            
            OnTriggerStickerEvent += TriggerSticker;
            
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Sticker"))
                return;
            OnTriggerStickerEvent?.Invoke();
        }

        private void TriggerSticker()
        {
            _stickerGrabInteractable.enabled = false;
            _stickerTransform.SetPositionAndRotation(_startTransform.position, _startTransform.rotation);
            _stickerRigidbody.isKinematic = true;
            _stickerGrabInteractable.enabled = true;
        }

        private void ChangeKinematic(SelectExitEventArgs args)
        {
            _stickerRigidbody.isKinematic = false;
        }

        struct StartTransform
        {
            public Vector3 position;
            public Quaternion rotation;
        }
        
        
    }
}