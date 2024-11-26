using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public string objectID;

    private void Awake()
    {
        objectID = name + transform.position.ToString(); //get a unique name for each object based on position so it doesn't delete same name objects
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Object.FindObjectsOfType<DontDestroy>().Length; i++) //get list of objects in this scene that were assigned this dontdestroy function
        {
            if (Object.FindObjectsOfType<DontDestroy>()[i] != this)
            {
                if (Object.FindObjectsOfType<DontDestroy>()[i].objectID == objectID)
                {
                Destroy(gameObject); //destroy dupilicate objects due to DontDestroyOnload
                }
            }
        }

        DontDestroyOnLoad(gameObject); //otherwise dont destory
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

