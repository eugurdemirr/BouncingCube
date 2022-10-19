using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ZombieController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float CharacterSpeed=0;
    private float movementX, movementY;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement*CharacterSpeed);

        Vector2 newScale = transform.localScale;

        if (movementX>0)
        {
            newScale.x= 0.65f;
        }
        if (movementX < 0)
        {
            newScale.x = -0.65f;
        }

        transform.localScale = newScale;
    }
}
