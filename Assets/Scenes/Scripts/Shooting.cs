using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint2;
    public Transform firePoint3;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if(Input.GetKey("right"))
            {
                Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            }
            else if(Input.GetKey("left"))
            {
                Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);
            }
            else
            {
                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            }
        }

    }
}
