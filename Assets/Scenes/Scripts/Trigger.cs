using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Explosion;
    public Transform explosionLocation;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Explosion, explosionLocation.position, transform.rotation);

        Destroy(Explosion.gameObject);
        Destroy(gameObject);
    }
}
