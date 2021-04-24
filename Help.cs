using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    public GameObject[] img;
    public void HelpMe()
    {
        for (int i = 0; i < img.Length; i++)
        {
            img[i].transform.GetComponent<SpriteRenderer>().color = Color.white; // изменение цвета
        }
    }
}
