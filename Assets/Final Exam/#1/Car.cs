using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    private float verticalInput;
    private float horizontalInput;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

   
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime * verticalInput);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        {
            transform.Rotate(Vector2.right * turnSpeed * Time.deltaTime * horizontalInput);
        }

        /*
         * FINAL EXAM #1
         * Write a script that will allow movement.
         * The Vertical Axis should make the player move forwards and backwards
         * The Horizontal Axis should make the player rotate on the Vector3.back axis
         */

    }
}
