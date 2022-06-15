using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShipLeft : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb2;

    public GameObject Explosion;
    public bool laserShip;

    // Start is called before the first frame update
    void Start()
    {
        if(laserShip == false)
        {
            speed = Random.Range(10, 30);
        }
        rb2.velocity = transform.right * speed;
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Instantiate(Explosion, transform.position, transform.rotation);

            Destroy(Explosion.gameObject);
            Destroy(gameObject);
        }

    }

}
