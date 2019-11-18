using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U_Shooting : MonoBehaviour
{

    public float m_Speed = 2000.0f;
    public GameObject Bulllet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Shoot()
    {
        GameObject bullet = Instantiate(Bulllet, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * 2000f);
    }
}
