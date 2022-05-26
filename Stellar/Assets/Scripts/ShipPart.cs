using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Stellar")
        {
            gameObject.SetActive(false);
            other.GetComponent<StellarController>().gotpart = true;
        }
    }
}
