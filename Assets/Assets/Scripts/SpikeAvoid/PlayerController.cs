using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    public float movementSpeed = 5;
    private float movementX;
    private bool moveRight = false;
    private bool moveLeft = false;
    private Vector3 currentPosition;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementX = -(context.ReadValue<Vector2>().x);
        rigidBody.AddForce(new Vector2(movementX * movementSpeed, 0.0f), ForceMode2D.Force);
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(movementX, 0.0f);
        rigidBody.AddForce(new Vector2(movementX * movementSpeed, 0.0f), ForceMode2D.Force);  
    }
}
