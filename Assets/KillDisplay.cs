using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillDisplay : MonoBehaviour
{
    TextMeshProUGUI text;
    public Var kill;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        kill.value = 0;
    }
    private void Update()
    {
        text.text = kill.value.ToString();
    }
}
