using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudarCursor : MonoBehaviour
{
    [SerializeField]
    private Texture2D cursorClick;
    [SerializeField]
    private Texture2D cursorNormal;

    [SerializeField]
    private CursorMode modoCursor = CursorMode.Auto;
    [SerializeField]
    private Vector2  hotSpot = Vector2.zero;

    public void setCursorNormal()
    {
        Cursor.SetCursor(cursorNormal, hotSpot, modoCursor);
    }

    public void setCursorClick()
    {
        Cursor.SetCursor(cursorClick, hotSpot, modoCursor);
    }  
}
