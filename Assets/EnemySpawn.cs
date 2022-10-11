using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.UIElements;
using UnityEditorInternal;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public int tracer;
    int count;
    public int cadence;
    public Var wrong;
    public Var kill;
    private void Awake()
    {
        count = 0;
        wrong.value = 0;
    }
    private void Update()
    {
        tracer = count % (cadence - 10 * kill.value);
        try
        {
            if (count % (cadence - 10 * kill.value) == 0) Instantiate(Enemy, transform);
        }
        catch { }
        if (Time.timeScale == 1) count++;
        if (cadence > 1000 && wrong.value != 0) cadence /= wrong.value; 
    }
}
