using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    byte count;
    SpriteRenderer sr;
    public Var kill;
    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        count = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            sr.color = Color.red;
        }
    }
    private void Update()
    {
        if (sr.color == Color.red) count++;
        if (count >= 200)
        {
            kill.value++;
            Destroy(gameObject);
        }
    }
}
