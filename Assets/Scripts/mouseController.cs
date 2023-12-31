using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseController : MonoBehaviour
{
    public Texture2D normalMouse;
    private Vector2 normalMouseHotSpot = new Vector2(0, 0);
    public Texture2D handMouse;
    public Texture2D handCloseMouse;
    private Vector2 handMouseHotSpot = new Vector2(0.5f, 0.5f);

    private bool inUse = false;

    private void Awake()
    {
        Cursor.SetCursor(normalMouse,normalMouseHotSpot,CursorMode.Auto);
    }

    public void setHandMouse()
    {
        if (inUse == false)
        {
            Cursor.SetCursor(handMouse,handMouseHotSpot,CursorMode.Auto);
        }
    }
    
    public void setNormalMouse()
    {
        if (inUse == false)
        {
            Cursor.SetCursor(normalMouse,normalMouseHotSpot,CursorMode.Auto);
        }
    }
    
    public void setHandCloseMouse()
    {
        if (inUse == false)
        {
             Cursor.SetCursor(handCloseMouse,handMouseHotSpot,CursorMode.Auto);
        }
    }

    public void setInUse(bool use)
    {
        inUse = use;
    }
}
