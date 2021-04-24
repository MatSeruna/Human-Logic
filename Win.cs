using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    private int pointsToWin, currentPoint;

    public GameObject puzzles;
    void Start()
    {
        pointsToWin = puzzles.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoint >= pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            StopAllCoroutines();
            GameObject.Find("TTimer").GetComponent<Timer>().StopAllCoroutines();
           
            print("U WON!");
        }
    }

    public void AddPoints()
    {
        currentPoint++;
    }
}
