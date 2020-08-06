using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float MouseX;
    public float MouseY;

    // Update is called once per frame
    void Update()
    {
        MouseX = Input.GetAxis("Mouse X");

        MouseY = Input.GetAxis("Mouse Y");
    }
}
