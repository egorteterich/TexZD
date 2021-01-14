using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 1;
    public float jumpforse;

    float MoveInput;

    public bool isGrounded = false;
    public float cheakRadius;
    public Transform cheakPosition;
    public Transform Resp;
    public LayerMask Ground;

    Animator anim;
    SpriteRenderer sprite;
    Rigidbody2D rb;

    public Joystick joystick;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float verticalMove = joystick.Vertical;
        isGrounded = Physics2D.OverlapCircle(cheakPosition.position, cheakRadius, Ground);

        MoveInput = joystick.Horizontal;
        if(Input.GetAxis("Horizontal") == 0)
        {
            anim.SetBool("Anim", false);
        }
        else
        {
            anim.SetBool("Anim", true);
        }

        rb.velocity = new Vector2(MoveInput * speed, rb.velocity.y);

        if (isGrounded == true && verticalMove >= 0.5f)
        {
            rb.AddForce(transform.up * jumpforse,ForceMode2D.Impulse);
            isGrounded = false;
        }
        Flip();
    }
    void Flip()
    {
        if (Input.GetAxis("Horizontal") < 0)
            sprite.flipX = true;
        if (Input.GetAxis("Horizontal") > 0)
            sprite.flipX = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            transform.position = Resp.position;
        }
    }

}
