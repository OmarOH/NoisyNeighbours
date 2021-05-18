using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D character;
    private Animator animator;
    private Vector2 movement;
    private Transform grabPoint;

    private void Awake()
    {
        character = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        grabPoint = transform.Find("GrabRange");
    }

    private void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        // Get the last direction input so the player faces the last direction of input when idle
        if(movement.x == 1 || movement.x == -1 
            || movement.y == 1 || movement.y == -1)
        {
            animator.SetFloat("LastHorizontal", movement.x);
            animator.SetFloat("LastVertical", movement.y);
        }

        if (animator.GetFloat("LastHorizontal") > 0) grabPoint.localRotation = Quaternion.Euler(0, 0, 90);
        if (animator.GetFloat("LastHorizontal") < 0) grabPoint.localRotation = Quaternion.Euler(0, 0, -90);
        if (animator.GetFloat("LastVertical") > 0) grabPoint.localRotation = Quaternion.Euler(0, 0, 180);
        if (animator.GetFloat("LastVertical") < 0) grabPoint.localRotation = Quaternion.Euler(0, 0, 0);
    }


    private void FixedUpdate()
    {
        // Movement
        character.MovePosition(character.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
