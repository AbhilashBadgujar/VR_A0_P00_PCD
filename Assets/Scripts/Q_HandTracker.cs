using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_HandTracker : MonoBehaviour
{
    public OVRInput.Controller controller;

    // Update is called once per frame
    void Update()
    {
        transform.position = OVRInput.GetLocalControllerPosition(controller);
        transform.rotation = OVRInput.GetLocalControllerRotation(controller);

    }
}
