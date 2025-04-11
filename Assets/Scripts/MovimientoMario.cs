using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMario : MonoBehaviour
{
public BoxCollider2D _boxCollider;
public Rigidbody2D _rigidBody2d;

 private bool groundedPlayer;

 private Vector2 playerVelocity;

 private readonly int InputHorizontal;
    void Start()
    {
        print(gameObject);
    }


    void Awake() 
    {
        _boxCollider = GetComponent<BoxCollider2D>();
        _rigidBody2d = GetComponent<Rigidbody2D>();

        
    }

    void Update()
    {
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 2f;
        }

        Movent();
    }


    void Movent()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), 0);

        if (move != Vector2.zero)
        {
            gameObject.transform.forward = move;
        }
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && groundedPlayer)
        {
            
        }

    }
}

