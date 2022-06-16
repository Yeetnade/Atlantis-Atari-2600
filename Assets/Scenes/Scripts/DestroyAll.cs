using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAll : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            GameObject[] ship1 = GameObject.FindGameObjectsWithTag("Ship1");
            GameObject[] ship2 = GameObject.FindGameObjectsWithTag("Ship2");
            GameObject[] ship3 = GameObject.FindGameObjectsWithTag("Ship3");

            foreach (GameObject enemy in ship1)
            {
                GameObject.Destroy(enemy);
                ScoreManager.sManager.IncreaseScore(100);
            }
            foreach (GameObject enemy2 in ship2)
            {
                GameObject.Destroy(enemy2);
                ScoreManager.sManager.IncreaseScore(200);
            }
            foreach (GameObject enemy3 in ship3)
            {
                GameObject.Destroy(enemy3);
                ScoreManager.sManager.IncreaseScore(1000);
            }
        }
    }
}
