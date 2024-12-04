using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject currentobject;


    public void copyobject()
    {
        GameObject newobject = Instantiate(currentobject);
        newobject.transform.localPosition = new Vector3(0.0f, 0.0f, 1.0f);
    }
}
