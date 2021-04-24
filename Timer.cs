using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int sec = 0, min = 2;

    public Text timer;
    void Start()
    {
        StartCoroutine(TimerSec());
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = "" + min + ":" + sec;
       
    }

    IEnumerator TimerSec()
    {
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

            if (sec <= 0 && min <= 0)
            {

            }
            
            yield return new WaitForSeconds(1f);
        }
        
        

    }
}
