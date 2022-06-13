using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShipsRight : MonoBehaviour
{
    float speed;
    public Rigidbody2D rb2;
    public GameObject Explosion;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(-10, -30);
        rb2.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Explosion, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
