using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CreateObjectCanvas;
    public GameObject ObjectsCanvas;


    public void transfromCanvas()
    {   
        float x =  CreateObjectCanvas.transform.position.x;
        float y =  CreateObjectCanvas.transform.position.y;
        float z =  CreateObjectCanvas.transform.position.z;
        CreateObjectCanvas.transform.position = ObjectsCanvas.transform.position;
        ObjectsCanvas.transform.position = new Vector3(x, y, z);
    }

}
