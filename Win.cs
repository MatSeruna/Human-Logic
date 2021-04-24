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
        pointsToWin = puzzles.transform.childCount; // ����������� ���-�� ������ ��� ������
    }

    
    void Update()
    {
        if (currentPoint >= pointsToWin) // �������� ������� ���� ������ � ���-���
        {
            WinLevel();            
        }
    }

    public void AddPoints() // ���������� ����� ��� ������
    {
        currentPoint++;
    }

    public void UnlockLevel() // ������������� ������ ������
    {
        int currentlevel = SceneManager.GetActiveScene().buildIndex;

        if (currentlevel >= PlayerPrefs.GetInt("levels")) 
        {
            PlayerPrefs.SetInt("levels", currentlevel + 1); // ���� ���������
        }
        SceneManager.LoadScene(currentlevel+1); // ���� �������
    }

    public void Lose() // ��������
    {
        GameObject.Find("TTimer").GetComponent<Timer>().StopAllCoroutines();
        transform.GetChild(0).gameObject.SetActive(true);
        lose = true;
        textwin.text = "�������!";
    }
    public void WinLevel() // ������
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        StopAllCoroutines();
        GameObject.Find("TTimer").GetComponent<Timer>().StopAllCoroutines();
        
    }
}
