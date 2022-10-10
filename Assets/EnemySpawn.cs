using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    int count;
    public int cadence;
    private void Awake()
    {
        count = 0;
    }
    private void Update()
    {
        if (count % cadence == 0) Instantiate(Enemy, transform); 
        count++;
    }
}
