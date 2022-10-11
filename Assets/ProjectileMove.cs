using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 move;
    public float speed;
    int count;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        move = (GameObject.Find("Spawn Projectile").transform.position - GameObject.Find("Player").transform.position).normalized;
        count = 0;
    }
    private void Update()
    {
        if (count >= 1000) Destroy(gameObject);
        count++;
    }
    private void FixedUpdate()
    {
        if (move == Vector2.zero) rb.velocity = Vector2.right * speed * Time.fixedDeltaTime;
        else rb.velocity = move * speed * Time.fixedDeltaTime;
    }
}
