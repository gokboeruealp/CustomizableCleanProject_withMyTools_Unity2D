using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    //only use Gokboerue class
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Gokboerue.CreatePopupText(Gokboerue.G_GetMousePosition(), Random.Range(100,1000).ToString());
        }
    }
}
