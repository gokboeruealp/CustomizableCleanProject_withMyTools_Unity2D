using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gokboerue : MonoBehaviour
{
    public static Vector2 G_GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public static void CreatePopupText(Vector2 position, string text)
    {
        PopupTextScript.Create(Gokboerue.G_GetMousePosition(), text);
    }
}
