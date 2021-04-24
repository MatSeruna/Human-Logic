using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    public bool lose = false;

    public Text textwin;
    public Text[] messages; //массив сообщений
    public GameObject[] bubbles; //массив изображений
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void UnlockLevel() //Разбл уровня
    {
        int currentlevel = SceneManager.GetActiveScene().buildIndex;

        if (currentlevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentlevel + 1);
        }
        
    }
    public void Lose() // Проигрыш
    {
        lose = true;
        textwin.text = "Обокрадено!";
        transform.GetChild(0).gameObject.SetActive(true);

        for (int i = 0; i < messages.Length; i++) // Показ текстов
        {
            messages[i].gameObject.SetActive(true);
        }
        for (int i = 0; i < bubbles.Length; i++) // Показ изображений сообщений
        {
            bubbles[i].SetActive(true);
        }
        
        GameObject.Find("TTimer").GetComponent<Timer>().StopAllCoroutines(); // Откл таймера
        GameObject.Find("Send").GetComponent<Button>().interactable = false; // Откл кнопки
        GameObject.Find("NotSend").GetComponent<Button>().interactable = false; // Откл кнопки
    }
    public void WinLevel() // Победа
    {
        UnlockLevel(); // Разбл уровня
        messages[0].text = "Мошенники!";
        messages[1].text = "О нееет! :'(";
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        
        for (int i = 0; i < messages.Length; i++)
        {
            messages[i].gameObject.SetActive(true);
        }
        for (int i = 0; i < bubbles.Length; i++)
        {
            bubbles[i].SetActive(true);
        }
        
        GameObject.Find("TTimer").GetComponent<Timer>().StopAllCoroutines();
        GameObject.Find("Send").GetComponent<Button>().interactable = false;
        GameObject.Find("NotSend").GetComponent<Button>().interactable = false;
    }
}
