using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb2;


    // Update is called once per frame
    void Start()
    {
        rb2.velocity = transform.up * speed;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

        if(collision.gameObject.tag == "Ship1")
        {
            ScoreManager.sManager.IncreaseScore(100);
        }
        else if (collision.gameObject.tag == "Ship2")
        {
            ScoreManager.sManager.IncreaseScore(200);
        }
        else if (collision.gameObject.tag == "Ship3")
        {
            ScoreManager.sManager.IncreaseScore(1000);
        }
    }
}
