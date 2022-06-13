using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb2;

    public int numberOfBullets;
    // Update is called once per frame
    void Start()
    {
        rb2.velocity = transform.up * speed;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        numberOfBullets++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        numberOfBullets--;
    }
}
