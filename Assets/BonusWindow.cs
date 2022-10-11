using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusWindow : MonoBehaviour
{
    public Var kill;
    public GameObject window;
    bool cba;
    private void Awake()
    {
        cba = true;
    }
    private void Update()
    {
        if (kill.value % 10 == 0 && kill.value != 0 && cba)
        {
            Time.timeScale = 0;
            window.SetActive(true);
            cba = false;
        }
        if (kill.value % 11 == 0) cba = true;
    }
}
