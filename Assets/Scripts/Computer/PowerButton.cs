using UnityEngine;

namespace Computer
{
    public class PowerButton : MonoBehaviour
    {
        [SerializeField] private DisplayScript _display;

        public void ToggleDisplay()
        {
            if (_display is not null)
                _display.TogglePower();
        }
    }
}
