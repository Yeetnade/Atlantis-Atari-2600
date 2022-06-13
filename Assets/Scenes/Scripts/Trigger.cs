using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject spawnPointRight;
    public GameObject spawnPointLeft;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        spawnPointLeft.SetActive(false);
        spawnPointRight.SetActive(false);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spawnPointLeft.SetActive(true);
        spawnPointRight.SetActive(true);
    }
}
