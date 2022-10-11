using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorLeft : MonoBehaviour
{
    Image image;
    public bool left;
    public Var wep;
    public GameObject window;
    private void Awake()
    {
        image = GetComponent<Image>();
        left = true;
    }
    private void Update()
    {
        if (left)
        {
            image.color = Color.magenta;
        }
        else
        {
            image.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) left = false;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) left = true;
        if (image.color == Color.magenta && Input.GetKeyDown(KeyCode.Space)) Left();
    }
    public void Left()
    {
        wep.value++;
        Time.timeScale = 1;
        window.SetActive(false);
    }
}
