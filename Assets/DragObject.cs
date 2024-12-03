using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Oculus.Interaction.Samples
{
    public class DragObject : MonoBehaviour
    {
        public Transform pointer;
        public GameObject newObject;
        [SerializeField] private ActiveStateSelector GoHere;
        private bool isGoHere;
        [Header("Select To Include In Drag")]
        public bool x;
        public bool y;
        public bool z;

        public void Drag()
        {   
            GoHere.WhenSelected += () => {isGoHere = true;};
            GoHere.WhenUnselected += () => {isGoHere = false;};
            if (isGoHere){
                float newX = x ? pointer.position.x : newObject.transform.position.x;
                float newY = y ? pointer.position.y : newObject.transform.position.y;
                float newZ = z ? pointer.position.z : newObject.transform.position.z;
                newObject.transform.position = new Vector3(newX, newY, newZ);
            }

            // if (isGoHere){
            //     float newX = pointer.position.x - (pointer.position.x/(pointer.position.x + pointer.position.y + pointer.position.z));
            //     float newY = pointer.position.y - (pointer.position.y/(pointer.position.x + pointer.position.y + pointer.position.z));
            //     float newZ = pointer.position.z - (pointer.position.z/(pointer.position.x + pointer.position.y + pointer.position.z));
            //     if (newX <= 0.1) newX = 0.1;
            //     if (newY <= 0.1) newX = 0.1;
            //     if (newZ <= 0.1) newX = 0.1;
            // }


        }
    }
}   
