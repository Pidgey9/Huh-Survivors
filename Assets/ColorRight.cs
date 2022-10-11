using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UI;

public class ColorRight : MonoBehaviour
{
    Image image;
    bool left;
    public GameObject window;
    public Var wrong;
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    private void Update()
    {
        left = GameObject.Find("Button Left").GetComponent<ColorLeft>().left;
        if (!left)
        {
            image.color = Color.magenta;
            if (Input.GetKeyDown(KeyCode.Space)) Right();
        }
        else
        {
            image.color = Color.white;
        }
    }
    public void Right()
    {
        Time.timeScale = 1;
        window.SetActive(false);
        wrong.value++;
    }
}
