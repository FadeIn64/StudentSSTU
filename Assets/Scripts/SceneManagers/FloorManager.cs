using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FloorManager : MonoBehaviour
{
    private readonly Dictionary<XRGrabInteractable, StartPosition> _startTransforms = new Dictionary<XRGrabInteractable, StartPosition>();
    // Start is called before the first frame update
    void Start()
    {
        var xrGrabInteractables = GameObject.FindObjectsByType<XRGrabInteractable>(FindObjectsSortMode.InstanceID);
        foreach (XRGrabInteractable xrGrabInteractable in xrGrabInteractables)
            Push(xrGrabInteractable);
    }

    public void CheckCollisionObject(GameObject gameObject)
    {
        var xrGrabInteractable = gameObject.GetComponent<XRGrabInteractable>();
        if (!_startTransforms.ContainsKey(xrGrabInteractable)) 
            Push(xrGrabInteractable);

        if(xrGrabInteractable.isSelected) return;
        
        ResetTransform(xrGrabInteractable);

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void Push(XRGrabInteractable xrGrabInteractable)
    {
        var obj = xrGrabInteractable.gameObject;
        var startPosition = new StartPosition
        {
            LocalPosition = obj.transform.localPosition,
            LocalRotation = obj.transform.localRotation
        };
        _startTransforms.Add(xrGrabInteractable, startPosition);
    }

    private void ResetTransform(XRGrabInteractable xrGrabInteractable)
    {
        var startPosition = _startTransforms[xrGrabInteractable];
        xrGrabInteractable.transform.SetLocalPositionAndRotation(startPosition.LocalPosition, startPosition.LocalRotation);

        var rigidbody = xrGrabInteractable.GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(0, 0, 0);
        rigidbody.angularVelocity = new Vector3(0, 0, 0);
    }
    

    
    struct StartPosition
    {
        public Vector3 LocalPosition;
        public Quaternion LocalRotation;
    }
}
