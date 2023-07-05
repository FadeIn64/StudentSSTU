using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    

    private void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.tag);
    }

    private void OnCollisionExit(Collision other)
    {
        print(other.gameObject.tag);
    }

    // private void OnTriggerExit(Collider other)
    // {
    //     print(other.gameObject.tag);
    // }

    private void OnTriggerStay(Collider other)
    {
        print(other.contactOffset);
    }
}
