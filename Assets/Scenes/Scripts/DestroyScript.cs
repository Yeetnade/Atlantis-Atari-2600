using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public GameObject laserAbove;
    public GameObject laserBelow;
    void OnTriggerEnter2D(Collider2D collision)
    {
        laserAbove.SetActive(false);
        laserBelow.SetActive(false);
    }

}
