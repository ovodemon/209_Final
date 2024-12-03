using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour

{
  public GameObject objectToChange; // The 3D object to change color
  public string hexColorCodeRed = "#FFFFFF"; // Default color is white
  public string hexColorCodeYellow = "#FFFFFF"; // Default color is white
  public string hexColorCodeBlue = "#FFFFFF"; // Default color is white
  public string hexColorCodeGreen = "#FFFFFF"; // Default color is white
  public string hexColorCodeCustom = "#FFFFFF"; // Default color is white
  private Renderer objectRenderer;

  void Start()

  {
    if (objectToChange != null)

    {

      objectRenderer = objectToChange.GetComponent<Renderer>();

    }

  }

  public void ChangeColorRed()
  {
    if (objectRenderer != null)
    {
      Color newColor;
      if (HexToColor(hexColorCodeRed, out newColor))
      {
        objectRenderer.material.color = newColor;
      }
      else
      {
        Debug.LogWarning("Invalid hex color code.");
      }
    }
  }
public void ChangeColorYellow()
  {
    if (objectRenderer != null)
    {
      Color newColor;
      if (HexToColor(hexColorCodeYellow, out newColor))
      {
        objectRenderer.material.color = newColor;
      }
      else
      {
        Debug.LogWarning("Invalid hex color code.");
      }
    }
  }
public void ChangeColorBlue()

  {

    if (objectRenderer != null)

    {

      Color newColor;

      if (HexToColor(hexColorCodeBlue, out newColor))

      {

        objectRenderer.material.color = newColor;

      }

      else

      {

        Debug.LogWarning("Invalid hex color code.");

      }

    }

  }



public void ChangeColorGreen()

  {

    if (objectRenderer != null)

    {

      Color newColor;

      if (HexToColor(hexColorCodeGreen, out newColor))

      {

        objectRenderer.material.color = newColor;

      }

      else

      {

        Debug.LogWarning("Invalid hex color code.");

      }

    }

  }



public void ChangeColorCustom()

  {

    if (objectRenderer != null)

    {

      Color newColor;

      if (HexToColor(hexColorCodeCustom, out newColor))

      {

        objectRenderer.material.color = newColor;

      }

      else

      {

        Debug.LogWarning("Invalid hex color code.");

      }

    }

  }



  private bool HexToColor(string hex, out Color color)

  {

    hex = hex.Replace("0x", ""); // Remove "0x" if present

    hex = hex.Replace("#", ""); // Remove "#" if present



    if (hex.Length == 6) // RGB

    {

      byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);

      byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);

      byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

      color = new Color32(r, g, b, 255);

      return true;

    }

    else if (hex.Length == 8) // RGBA

    {

      byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);

      byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);

      byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

      byte a = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);

      color = new Color32(r, g, b, a);

      return true;

    }



    color = Color.clear;

    return false;

  }

}