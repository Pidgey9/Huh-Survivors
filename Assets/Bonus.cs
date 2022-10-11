using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public Var wep;
    private void Awake()
    {
        wep.value = 1;
    }
}
