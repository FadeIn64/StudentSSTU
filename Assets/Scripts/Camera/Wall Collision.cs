using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{

    [SerializeField]
    private GameObject _panel;
    
    private void OnTriggerEnter(Collider other)
    {
        if(!other.gameObject.CompareTag("Wall"))
            return;
        _panel.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if(!other.gameObject.CompareTag("Wall"))
            return;
        _panel.SetActive(false);
    }
}
