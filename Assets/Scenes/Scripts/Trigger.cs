using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Explosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("City"))
        {
            Instantiate(Explosion, transform.position, transform.rotation);

            Destroy(Explosion.gameObject);
            Destroy(gameObject);
        }
    }
}
