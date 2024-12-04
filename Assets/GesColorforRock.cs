using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Oculus.Interaction.Samples
{
    public class GesColorforRock : MonoBehaviour
    {
        private bool isChange = false;
        private bool isDelete = false;
        public ActiveStateSelector ChangeGesture;
        public ActiveStateSelector DeleteGesture;
        public GameObject objectToChangeColor1;
        public GameObject objectToChangeColor2;
        public GameObject objectToChangeColor3;
        public GameObject objectToChangeLocation;
        public GameObject cursorVisual;

        private Renderer objectRenderer;
        //public string hexColorCodeCustom = "#FFFFFF"; // Default color is white
        private int Hue = 1;
        public static bool isSelected = false;

        // Start is called before the first frame update
        public void Selected()
        {
            objectRenderer = objectToChangeColor1.GetComponent<Renderer>();
            objectRenderer = objectToChangeColor2.GetComponent<Renderer>();
            objectRenderer = objectToChangeColor3.GetComponent<Renderer>();
            isSelected = true;
        }
        public void unSelected()
        {
            objectRenderer = null;
            isSelected = false;
            objectToChangeLocation.transform.position = cursorVisual.transform.position;
            if (isDelete){
                //objectToChangeLocation.transform.position = new Vector3 (-500,-500,-500);
                Destroy(objectToChangeLocation);
            }

        }
        public void ChangeColor()
        {   
            // objectRenderer = objectToChange.GetComponent<Renderer>();
            // ChangeGesture.WhenSelected += () => {isChange = true;};
            // ChangeGesture.WhenUnselected += () => {isChange = false;}; 
            // Color newColor;
            // float Sat = 0.7f;
            // float Value = 0.7f;
            // if (isChange){
            //     objectRenderer.material.color = Color.HSVToRGB(Hue/360f, Sat, Value);
            //     Hue = Hue + 5;
            //     if (Hue >= 360){
            //         Hue = 1;
            //     }
            // }
        }

        // Update is called once per frame
        void Update()
        {   
            //objectRenderer = objectToChange.GetComponent<Renderer>();
            ChangeGesture.WhenSelected += () => {isChange = true;};
            ChangeGesture.WhenUnselected += () => {isChange = false;}; 
            DeleteGesture.WhenSelected += () => {isDelete = true;};
            DeleteGesture.WhenUnselected += () => {isDelete = false;}; 
            float Sat = 0.7f;
            float Value = 0.7f;
            if (isChange && isSelected){
                objectRenderer.material.SetColor("_TopColor",Color.HSVToRGB(Hue/360f, Sat, Value)) ;
                Hue = Hue + 5;
                if (Hue >= 360){
                    Hue = 1;
                }
            }

        }
    }
}
