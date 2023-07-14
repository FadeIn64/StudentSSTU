using UnityEngine;

namespace LightSwitch
{
    public class LightSwitch : MonoBehaviour
    {
        private Light _light;
        private void Start()
        {
            _light = FindObjectOfType<Light>();
        }

        public void ToggleLight()
        {
            _light.intensity = (_light.intensity > 0)? 0: 1;
        }
    }
}