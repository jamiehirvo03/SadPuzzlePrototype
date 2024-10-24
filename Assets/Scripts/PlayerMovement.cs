using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 3f;
    private float jumpingPower = 4f;

    [SerializeField] private bool isFacingRight;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private Vector3 playerLocation;
    public GameObject teardropPrefab;

    [SerializeField] private bool isPlayerCrying;

    private void Start()
    {
        isFacingRight = true;

        isPlayerCrying = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            isFacingRight = true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            isFacingRight = false;
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isFacingRight)
            {
                playerLocation = new Vector3(transform.position.x + 0.4f, transform.position.y + 0.3f, transform.position.z);
            }
            else
            {
                playerLocation = new Vector3(transform.position.x - 0.4f, transform.position.y + 0.3f, transform.position.z);
            }

            GameObject teardrop = Instantiate(teardropPrefab, playerLocation, Quaternion.identity);
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    { 
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal <0f || isFacingRight && speed < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale; 

        }
    }
}
