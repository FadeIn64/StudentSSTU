using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Extension
{
    public class PowerButton : MonoBehaviour
    {
        private Transform _transform;

        private void Start()
        {
            _transform = transform;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player"))
                return;
            var rotation = _transform.localRotation.eulerAngles;
            rotation.y *= -1;
            _transform.SetLocalPositionAndRotation(_transform.localPosition, Quaternion.Euler(rotation));
        }
    }
}