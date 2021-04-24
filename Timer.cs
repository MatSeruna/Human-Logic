using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int sec = 15, min = 0;

    public Text timer; //Текст таймера
    void Start()
    {
        StartCoroutine(TimerSec()); //Стар корутины таймера
    }

    
    void Update()
    {
        timer.text = "" + min + ":" + sec; // Вывод таймера
       
    }

    IEnumerator TimerSec() //таймер
    {
        // Уменьшение каждую секунду
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
            
            // Победа при окончании времени во 2 уровне
            if (sec <= 0 && min <= 0)
            {
                GameObject.Find("WinScript").GetComponent<Level2>().WinLevel();
            }
            
            yield return new WaitForSeconds(1f);
        }
        
        

    }
}
