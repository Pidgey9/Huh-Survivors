using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 move;
    public float speed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        move = - (transform.position - GameObject.Find("Player").transform.position).normalized;
    }
    private void FixedUpdate()
    {
        if (gameObject.GetComponent<SpriteRenderer>().color != Color.red) rb.velocity = move * speed * Time.fixedDeltaTime;
        else rb.velocity = Vector2.zero;
    }
}
