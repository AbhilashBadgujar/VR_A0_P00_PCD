using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys
{
    public static KeyCode moveForward = KeyCode.W;
    public static KeyCode moveBack = KeyCode.S;
    public static KeyCode rotateLeft = KeyCode.A;
    public static KeyCode rotateRight = KeyCode.D;
    public static KeyCode pitchUp = KeyCode.F;
    public static KeyCode pitchDown = KeyCode.V;
    public static KeyCode rollLeft = KeyCode.Q;
    public static KeyCode rollRight = KeyCode.E;
}



public class MouseMove : MonoBehaviour
{

    float horizontalSpeed = 0.3f;
    float verticalSpeed = 0.3f;
    float depthDelta = 0.1f;
    float rotateDelta = 1.0f;


    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //movement 3 axes
        float x = horizontalSpeed * Input.GetAxis("Mouse X");
        float y = verticalSpeed * Input.GetAxis("Mouse Y");
        float z = 0f;

        if (Input.GetKey(Keys.moveForward))
            z = depthDelta;
        else if (Input.GetKey(Keys.moveBack))
            z = -depthDelta;

        transform.Translate(x, y, z, Space.World);  

        //rotate 3 axes

        float rx,ry,rz;
        rx=ry=rz=0f;

        if (Input.GetKey(Keys.rotateLeft))
            ry = -rotateDelta;
        else if (Input.GetKey(Keys.rotateRight))
            ry = rotateDelta;

        if (Input.GetKey(Keys.pitchUp))
            rx = -rotateDelta;
        else if (Input.GetKey(Keys.pitchDown))
            rx = rotateDelta;

        if (Input.GetKey(Keys.rollLeft))
            rz = rotateDelta;
        else if (Input.GetKey(Keys.rollRight))
            rz = -rotateDelta;


        transform.Rotate(rx, ry, rz, Space.World);

    }
}
