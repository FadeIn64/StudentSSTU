using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFloor : MonoBehaviour
{
    public FloorManager FloorManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        FloorManager.CheckCollisionObject(other.gameObject);
    }
}
