using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public GameObject colorobject;
    private MeshRenderer objectRenderer;
    public void ChangeColor()
    {
        objectRenderer = colorobject.GetComponent<MeshRenderer>();
        objectRenderer.material.SetColor("_Color", Random.ColorHSV());
    }
}