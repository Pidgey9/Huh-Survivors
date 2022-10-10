using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 move;
    public float speed;
    Animator animator;
    float orientationH;
    float orientationV;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        move = new Vector2(h , v ).normalized;
        if (move.x == 0 && move.y == 0) animator.SetBool("NotMoving", true);
        else
        {
            animator.SetBool("NotMoving", false);
            orientationH = move.x;
            orientationV = move.y;
        }
        animator.SetFloat("Horizontal", orientationH);
        animator.SetFloat("Vertical", orientationV);
    }
    private void FixedUpdate()
    {
        rb.velocity = move * speed * Time.fixedDeltaTime;
    }
}
