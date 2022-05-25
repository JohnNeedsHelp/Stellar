using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScene : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<StellarController>() != null)
        {
            SceneManager.LoadScene("STELLAR LEVEL 2");
        }


    }

}
