using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    public bool lose = false;

    public Text textwin;
    public Text[] messages; //������ ���������
    public GameObject[] bubbles; //������ �����������
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void UnlockLevel() //����� ������
    {
        int currentlevel = SceneManager.GetActiveScene().buildIndex;

        if (currentlevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentlevel + 1);
        }
        
    }
    public void Lose() // ��������
    {
        lose = true;
        textwin.text = "����������!";
        transform.GetChild(0).gameObject.SetActive(true);

        for (int i = 0; i < messages.Length; i++) // ����� �������
        {
            messages[i].gameObject.SetActive(true);
        }
        for (int i = 0; i < bubbles.Length; i++) // ����� ����������� ���������
        {
            bubbles[i].SetActive(true);
        }
        
        GameObject.Find("TTimer").GetComponent<Timer>().StopAllCoroutines(); // ���� �������
        GameObject.Find("Send").GetComponent<Button>().interactable = false; // ���� ������
        GameObject.Find("NotSend").GetComponent<Button>().interactable = false; // ���� ������
    }
    public void WinLevel() // ������
    {
        UnlockLevel(); // ����� ������
        messages[0].text = "���������!";
        messages[1].text = "� �����! :'(";
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
