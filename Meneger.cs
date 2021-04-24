using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Meneger : MonoBehaviour
{

    public void ShowText(InputField InputField)
    {
        Debug.Log(InputField.text);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("1 level");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
    }
    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public string userPassword;
    [Header("Мой пароль")]
    [TextArea]
    public string myMeneger = "123";
    [Header("Поле ввода")]
    public Text entryField;
    [Header("Вывод на экран")]
    public Text outputOnDisplay;
    [Header("Загрузить сцену")]
    [TextArea]
    public string sceneName;
    [Header("Подтвердить ввод")]
    public Button myButton;

     void Start()
    {
        //myButton.onClick.AddListener(Enter);
    }

     void Enter()
    {
        userPassword = entryField.GetComponent<Text>().text;
        if (userPassword==myMeneger)
        {
            outputOnDisplay.GetComponent<Text>().text = "Доступ открыт";
            //SceneManager.LoadScene(sceneName);
        }
        if (userPassword!=myMeneger) 
        {
            outputOnDisplay.GetComponent<Text>().text = "Нет доступа";
        }
    }

    
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
