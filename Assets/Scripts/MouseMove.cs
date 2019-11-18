using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys
{
    public static KeyCode MoveForward = KeyCode.W;
    public static KeyCode MoveBack = KeyCode.S;
}



public class MouseMove : MonoBehaviour
{

    float horizontalSpeed = 0.3f;
    float verticalSpeed = 0.3f;
    float depthForward = 0.1f;
    float depthBack = -0.1f;

    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        float x = horizontalSpeed * Input.GetAxis("Mouse X");
        float y = verticalSpeed * Input.GetAxis("Mouse Y");
        float z = 0f;

        if (Input.GetKey(Keys.MoveForward))
            z = depthForward;
        else if (Input.GetKey(Keys.MoveBack))
            z = depthBack;

        transform.Translate(x, y, z);
    }
}
