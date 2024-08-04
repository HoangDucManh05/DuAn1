using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    Vector2 direction;
    public float speed = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       

        direction.x = Input.GetAxisRaw("Fire1");
        direction.y = Input.GetAxisRaw("Fire2");
        direction.Normalize();



    }

    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }
}
