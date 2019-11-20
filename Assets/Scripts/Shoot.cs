using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    private float bulletSpeed = 4000f;
       
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(BulletPrefab, transform.GetChild(2).position, transform.localRotation);       
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);          //add force to shoot projectile
        }
    }
}


//TBD: add object pooling for bullets
/*

const int numBullets = 3;      //at most there can be three active bullets
private GameObject[] bullets = new GameObject[numBullets];
private int bulletIndex=0;

bullets[bulletIndex] = Instantiate(BulletPrefab,pos,rot);
bulletIndex++;
if (bulletIndex == numBullets) bulletIndex = 0;   //there can only be <numBullets> bullets at a time
*/
