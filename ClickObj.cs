using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObj : MonoBehaviour
{
    public GameObject correctForm; // ѕравильна€ форма пазла
    private bool moving, placed;

    private float startPosX, startPosY; // Ќачальные позици€ курсора

    private Vector3 resetPosition;

    private void Start()
    {
        resetPosition = this.transform.localPosition; //изменение позиции
    }
    private void Update()
    {
        if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z); //перемещение мышкой
        }
    }
    private void OnMouseDown()
    {
        // ¬з€тие пазла, пока мы еще не проиграли и она еще не вставлена
        if (Input.GetMouseButtonDown(0) && !placed && !GameObject.Find("WinScript").GetComponent<Win>().lose)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            
            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
         
    }

    private void OnMouseUp()
    {
        // ќтпускание пазла
        moving = false;
        //вычисление позиции пазла и его формы
        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.5f)
        {
            //«акрепление пазла на форму
            this.transform.localPosition = new Vector3(correctForm.transform.localPosition.x, correctForm.transform.localPosition.y, correctForm.transform.localPosition.z); 
            placed = true;

            GameObject.Find("WinScript").GetComponent<Win>().AddPoints(); // ƒобавление очков дл€ вычислени€ победы
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z); // »наче пазл вернетс€ в свое изначальное местоположение
        }
    }
}
