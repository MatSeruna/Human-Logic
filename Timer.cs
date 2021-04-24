using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int sec = 15, min = 0;

    public Text timer; //����� �������
    void Start()
    {
        StartCoroutine(TimerSec()); //���� �������� �������
    }

    
    void Update()
    {
        timer.text = "" + min + ":" + sec; // ����� �������
       
    }

    IEnumerator TimerSec() //������
    {
        // ���������� ������ �������
        while(true)
        {
            if (sec == 0)
            {
                sec = 59;
                min--;
            }
            else if (sec != 0)
            {
                sec--;
            }
            
            // ������ ��� ��������� ������� �� 2 ������
            if (sec <= 0 && min <= 0)
            {
                GameObject.Find("WinScript").GetComponent<Level2>().WinLevel();
            }
            
            yield return new WaitForSeconds(1f);
        }
        
        

    }
}
