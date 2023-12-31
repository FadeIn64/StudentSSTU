using UnityEngine;

namespace Teleport
{
    public class TeleportInteraction
        : MonoBehaviour
    {
        [SerializeField]
        private TeleportManager _teleportManager;

        [SerializeField] private TeleportPlacement _teleportPlacement;
    
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        public void Teleport()
        {
            if (_teleportManager is null || _teleportPlacement is null)
                return;
            _teleportManager.Teleport(_teleportPlacement);
        }
    }
}
