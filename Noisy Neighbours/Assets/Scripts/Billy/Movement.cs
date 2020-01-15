using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D character;
    Vector2 movement;

    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }


    void FixedUpdate()
    {
        // Movement
        character.MovePosition(character.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
