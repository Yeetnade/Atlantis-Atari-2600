using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public GameObject Explosion;
    public Transform explosionLocation;
    public int numberOfBuildings;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Explosion, explosionLocation.position, transform.rotation);
        Destroy(Explosion.gameObject);
        gameObject.SetActive(false);
    }
}
