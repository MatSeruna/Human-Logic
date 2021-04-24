using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    int levelpoint; // Прогресс
    public Button[] buttons; // Кнопки уровней
    void Start()
    {
        levelpoint = PlayerPrefs.GetInt("levels", 1); // Сохранение прогресса в PlayerPrefs

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false; // Откл не доступных уровней
        }

        for (int i = 0; i < levelpoint; i++)
        {
            buttons[i].interactable = true; // Вкл не доступных уровней
        }
    }

    
    
    
}
