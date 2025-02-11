using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

//using System.Diagnostics;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3  movement = new Vector3(moveHorizontal * speed, rb.velocity.y, moveVertical * speed);
        rb.velocity = movement;
    }

    
}
