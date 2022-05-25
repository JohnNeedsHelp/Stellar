using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        StellarController controller = other.GetComponent<StellarController>();

        if(controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);

                Destroy(gameObject);

                
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
