using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour
{

    public Texture2D crosshairimg;
    public Rect position;
   
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        position = new Rect((Screen.width - crosshairimg.width) / 2, (Screen.height - crosshairimg.height) / 2, crosshairimg.width, crosshairimg.height);
    }
    void OnGUI()
    {
        GUI.DrawTexture(position, crosshairimg);
    }

}