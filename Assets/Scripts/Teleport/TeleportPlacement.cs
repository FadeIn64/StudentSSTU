using UnityEngine;
using UnityEngine.Events;

namespace Teleport
{
    public class TeleportPlacement : MonoBehaviour
    {

        [SerializeField]
        private Transform _teleportTransform;

        [SerializeField]
        private bool _changeYPosition;
        

        [SerializeField]
        private UnityEvent OnTeleportEvent;
        
        [SerializeField]
        private UnityEvent FromTeleportEvent;
        

        // Start is called before the first frame update
        void Start()
        {
            if (_teleportTransform == null)
                _teleportTransform = gameObject.transform;
            
            if (OnTeleportEvent == null)
                OnTeleportEvent = new UnityEvent();
            if (FromTeleportEvent == null)
                FromTeleportEvent = new UnityEvent();
            
        }

        internal void TeleportFromPlacement()
        {
            if (FromTeleportEvent == null)
                return;
            FromTeleportEvent.Invoke();
        }

        internal void TeleportToPlacement(GameObject teleportObject)
        {
            var teleportVector = _teleportTransform.position;
            teleportVector.y = (_changeYPosition) ? teleportVector.y : teleportObject.transform.position.y;
            teleportObject.transform.SetPositionAndRotation(teleportVector, teleportObject.transform.rotation);
            if (OnTeleportEvent == null)
                return;
            OnTeleportEvent.Invoke();
        }
        
    }
}
