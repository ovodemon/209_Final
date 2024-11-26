using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    public Transform pointer;
    public GameObject newObject;

    [Header("Select To Include In Drag")]
    public bool x;
    public bool y;
    public bool z;

    public void Drag()
    {
        float newX = x ? pointer.position.x : newObject.transform.position.x;
        float newY = y ? pointer.position.y : newObject.transform.position.y;
        float newZ = z ? pointer.position.z : newObject.transform.position.z;
        newObject.transform.position = new Vector3(newX, newY, newZ);
    }
}
