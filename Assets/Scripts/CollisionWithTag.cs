using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionWithTag : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _event;

    [SerializeField]
    private string _collisionTag;
    private void OnCollisionEnter(Collision other)
    {
        if (_event is not null && other.gameObject.CompareTag(_collisionTag))
            _event.Invoke();

    }
}
