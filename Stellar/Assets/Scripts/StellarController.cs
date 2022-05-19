using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StellarController : MonoBehaviour
{
    public float speed = 3.0f;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * speed * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * speed * Time.deltaTime;
        transform.position = position;
    }
}

