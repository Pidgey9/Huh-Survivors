using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProj : MonoBehaviour
{
    public GameObject projectile;
    int count;
    private void Awake()
    {
        count = 0;
    }
    private void Update()
    {
        if (count == 100)
        {
            Instantiate(projectile, GameObject.Find("Spawn Projectile").transform);
            count = 0;
        }
        count++;
    }
}
