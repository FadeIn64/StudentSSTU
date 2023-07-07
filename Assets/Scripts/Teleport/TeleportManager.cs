using UnityEngine;

namespace Teleport
{
    public class TeleportManager : MonoBehaviour
    {
        [SerializeField] 
        private GameObject _teleportObject;

        [SerializeField] 
        private TeleportPlacement _startPlacement;
        
        private TeleportPlacement _currentPlacement;

        // Start is called before the first frame update
        void Start()
        {
            if (_teleportObject == null)
                _teleportObject = gameObject;
            if (_startPlacement is not null)
            {
                _startPlacement.TeleportToPlacement(_teleportObject);
                _currentPlacement = _startPlacement;
            }
        }

        internal void Teleport(TeleportPlacement to)
        {
            if(_currentPlacement is not null)
                _currentPlacement.TeleportFromPlacement();
            _currentPlacement = to;
            to.TeleportToPlacement(_teleportObject);
        }

        
    }
}
