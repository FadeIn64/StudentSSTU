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

        private delegate void OnTriggerSticker();

        private event OnTriggerSticker OnTriggerStickerEvent;

        private void Start()
        {
            _stickerGameObject = _stickerGrabInteractable.gameObject;
            _stickerGameObject.tag = "Sticker";
            _stickerTransform = _stickerGrabInteractable.transform;
            _startTransform.position = transform.position;
            _startTransform.rotation = transform.rotation;
            
            OnTriggerStickerEvent += TriggerSticker;
            
        }

        private void OnTriggerEnter(Collider other)
        {
            if (! other.CompareTag("Sticker"))
                return;
            OnTriggerStickerEvent?.Invoke();
        }

        private void TriggerSticker()
        {
            _stickerGrabInteractable.enabled = false;
            _stickerTransform.SetPositionAndRotation(_startTransform.position, _startTransform.rotation);
        }

        struct StartTransform
        {
            public Vector3 position;
            public Quaternion rotation;
        }
        
        
    }
}