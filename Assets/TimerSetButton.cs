using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSetButton : MonoBehaviour
{

    private LightColorChange LightScript;
    
    // Start is called before the first frame update
    void Start()
    {
        LightScript = GetComponent<LightColorChange>();
    }

    public void SetTime5s()
    {
    LightScript.timeLimit = 5f;
    LightScript.timer = 0f;
    }

    public void SetTime10s()
    {
    LightScript.timeLimit = 10f;
    LightScript.timer = 0f;
    }

    public void SetTime20s()
    {
    LightScript.timeLimit = 20f;
    LightScript.timer = 0f;
    }

    public void SetTime1min()
    {
    LightScript.timeLimit = 60f;
    LightScript.timer = 0f;
    }

    public void SetTime5min()
    {
    LightScript.timeLimit = 300f;
    LightScript.timer = 0f;
    }

    public void ResetTime()
    {
    LightScript.timeLimit = 50000f;
    LightScript.timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
