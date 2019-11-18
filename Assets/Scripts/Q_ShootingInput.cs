using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_ShootingInput : MonoBehaviour
{

    [SerializeField] U_Shooting shooting;
    public OVRInput.Controller m_Controller = OVRInput.Controller.None;
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, m_Controller))
            shooting.Shoot();

        //if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, m_Controller))
            
    }
}
