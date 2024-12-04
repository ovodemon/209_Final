using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Oculus.Interaction.Samples
{
    public class GesColor : MonoBehaviour
    {
        private bool isChange = false;
        private bool isDelete = false;
        private bool isSize = false;
        public ActiveStateSelector ChangeGesture;
        public ActiveStateSelector DeleteGesture;
        public ActiveStateSelector SizeGesture;
        public GameObject objectToChangeColor;
        public GameObject objectToChangeLocation;
        public GameObject cursorVisual;
        public GameObject LeftHand;
        public GameObject RightHand;
        private Renderer objectRenderer;
        //public string hexColorCodeCustom = "#FFFFFF"; // Default color is white
        private int Hue = 1;
        public static bool isSelected = false;
        private float lastDistance;
        // Start is called before the first frame update
        public void Selected()
        {
            objectRenderer = objectToChangeColor.GetComponent<Renderer>();
            lastDistance = (LeftHand.transform.position - RightHand.transform.position).magnitude;
            isSelected = true;
        }
        public void unSelected()
        {
            objectRenderer = null;
            isSelected = false;
            
            if (isDelete){
                //objectToChangeLocation.transform.position = new Vector3 (-500,-500,-500);
                Destroy(objectToChangeLocation);
            }else {
                objectToChangeLocation.transform.position = cursorVisual.transform.position;
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
            SizeGesture.WhenSelected += () => {isSize = true;};
            SizeGesture.WhenUnselected += () => {isSize = false;};
            float Sat = 0.7f;
            float Value = 0.7f;
            if (isChange && isSelected){
                objectRenderer.material.SetColor("_TopColor",Color.HSVToRGB(Hue/360f, Sat, Value)) ;
                objectRenderer.material.SetColor("_GroundColor",Color.HSVToRGB(Hue/360f, Sat, Value)) ;
                Hue = Hue + 5;
                if (Hue >= 360){
                    Hue = 1;
                }
            }

            if (isSize && isSelected){
                float currentDistance = (LeftHand.transform.position - RightHand.transform.position).magnitude;
                objectToChangeLocation.transform.localScale = objectToChangeLocation.transform.localScale * (currentDistance/lastDistance);
            }

        }
    }
}
