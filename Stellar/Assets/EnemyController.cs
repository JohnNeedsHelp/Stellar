using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed;
    public bool vertical;
    public float changeTime = 3.0f;

    int direction = 1;

    Rigidbody2D rigidbody2D;
    float timer;

   // Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction; ;
            
            //animator.SetFloat("Move X", 0);
            //animator.SetFloat("Move Y", direction);
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction; ;
            //animator.SetFloat("Move X", direction);
            //animator.SetFloat(Move Y", 0);
        }

        rigidbody2D.MovePosition(position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        StellarController player = other.gameObject.GetComponent<StellarController>();

        if(player != null)
        {
            player.ChangeHealth(-1);
        }
    }


}
