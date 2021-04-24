using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    private int pointsToWin, currentPoint;
    public bool lose = false;

    public Text textwin;
    public GameObject puzzles;
    void Start()
    {
        pointsToWin = puzzles.transform.childCount; // Подсчитание кол-во пазлов для победы
    }

    
    void Update()
    {
        if (currentPoint >= pointsToWin) // Проверка текущих собр пазлов с кол-вом
        {
            WinLevel();            
        }
    }

    public void AddPoints() // Добавление очков для победы
    {
        currentPoint++;
    }

    public void UnlockLevel() // Разблокировка нового уровня
    {
        int currentlevel = SceneManager.GetActiveScene().buildIndex;

        if (currentlevel >= PlayerPrefs.GetInt("levels")) 
        {
            PlayerPrefs.SetInt("levels", currentlevel + 1); // сохр прогресса
        }
        SceneManager.LoadScene(currentlevel+1); // След уровень
    }

    public void Lose() // Проигрыш
    {
        GameObject.Find("TTimer").GetComponent<Timer>().StopAllCoroutines();
        transform.GetChild(0).gameObject.SetActive(true);
        lose = true;
        textwin.text = "Неудача!";
    }
    public void WinLevel() // Победа
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        StopAllCoroutines();
        GameObject.Find("TTimer").GetComponent<Timer>().StopAllCoroutines();
        
    }
}
