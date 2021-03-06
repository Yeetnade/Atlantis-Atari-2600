using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        GameObject[] buildings = GameObject.FindGameObjectsWithTag("City");

        if(buildings.Length == 0)
        {
            SceneManager.LoadScene(1);
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(0);
    }
}
