using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    string texto = "Hello World";
    public void OnGUI()
    {
        GUI.skin.label.fontSize = 30;
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 200), texto);
    }
}