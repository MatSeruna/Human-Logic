using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    int levelpoint; // ��������
    public Button[] buttons; // ������ �������
    void Start()
    {
        levelpoint = PlayerPrefs.GetInt("levels", 1); // ���������� ��������� � PlayerPrefs

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false; // ���� �� ��������� �������
        }

        for (int i = 0; i < levelpoint; i++)
        {
            buttons[i].interactable = true; // ��� �� ��������� �������
        }
    }

    
    
    
}
