using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LightColorChange : MonoBehaviour
{
    //LIGHT COMPONENT THAT IS REFERENCED FOR THE DIMING
    public Light lightSource;

    //VARIABLES

    //TOTAL TIME LIMIT DEFINED BY USER
    public float timeLimit = 10f;

    //VARIABLE THAT STORES THE TIME ELAPSED. INITIALLY AT ZERO
    public float timer = 0f;

    //READ IN THE INITIAL LIGHT COLOR OF THE LIGHT SOURCE TO MODIFY
    private Color initialLight;
    

    void Start()
    {
        //CHECK IF THERE IS A DIRECTIONAL LIGHT ATTACHED
        if (lightSource == null)
        {
            lightSource = GetComponent<Light>();
        }

        initialLight = lightSource.color;
    }

    void Update()
    {
        //ADJUST THE VALUE OF THE GREEN COMPONENT OF THE DIRECTIONAL LIGHT ACCORDING TO THE TIME
        if (timer < timeLimit)
        {
            timer = timer + Time.deltaTime; // Increment the timer by the time passed

            //UPDATE THE BLUE AND GREEN VALUES ACCORDINGLY
            float greenValue = Mathf.Lerp(1f, 0f, timer / timeLimit); //1: green, 0: no green
            float blueValue = Mathf.Lerp(1f, 0.5f, timer / timeLimit); //1: blue, 0.5: some blue

           //OUTPUT THE NEW DIRECTIONAL LIGHT COLOR WITH modified green and blue values
            lightSource.color = new Color(initialLight.r, greenValue, blueValue);
            lightSource.intensity = Mathf.Lerp(1f, 0f, timer / timeLimit);
        }

    }
}