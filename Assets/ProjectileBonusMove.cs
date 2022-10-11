using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBonusMove : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 move;
    public float speed;
    public int id;
    int count;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (id == 2) move = (GameObject.Find("Proj2").transform.position - GameObject.Find("Player").transform.position).normalized;
        if (id == 3) move = (GameObject.Find("Proj3").transform.position - GameObject.Find("Player").transform.position).normalized;
        if (id == 4) move = (GameObject.Find("Proj4").transform.position - GameObject.Find("Player").transform.position).normalized;
        count = 0;
    }
    private void Update()
    {
        if (count >= 1000) Destroy(gameObject);
        count++;
    }
    private void FixedUpdate()
    {
        rb.velocity = move * speed * Time.fixedDeltaTime;
    }
}
