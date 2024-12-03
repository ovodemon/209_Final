using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimesUpText : MonoBehaviour
{
    //TEXT MESSAGE COMPONENT THAT IS REFERENCED
    public TextMeshProUGUI  endTextMsg;

    //VARIABLES
    private LightColorChange LightScript;
    
    //TOTAL TIME LIMIT DEFINED BY USER
    //VARIABLE THAT STORES THE TIME ELAPSED. INITIALLY AT ZERO


    void Start()
    {
        LightScript = GetComponent<LightColorChange>();

            //TEXT INITIALIZATION
        endTextMsg.text = "I am at peace"; // BLANK TEXT
    }

    void Update()
        {
        //INCREMENT THE TIME ON EACH UPDATE CYCLE
        //LightScript.timer = LightScript.timer + Time.deltaTime;
            if (LightScript.timer >= LightScript.timeLimit)
                {
                    endTextMsg.text = "You Got This!"; //END TEXT
            }else{
                endTextMsg.text = "I am at peace"; // BLANK TEXT
            }
        }
}
