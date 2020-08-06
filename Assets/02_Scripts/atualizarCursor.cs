using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atualizarCursor : MonoBehaviour
{
    public mudarCursor cursor;

    void Start()
    {
        cursor = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<mudarCursor>();
    }

    void OnMouseEnter()
    {
        cursor.setCursorClick();
    }

     void OnMouseExit()
    {
        cursor.setCursorNormal();
    }

}
