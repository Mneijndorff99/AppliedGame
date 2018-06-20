using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventScript : MonoBehaviour
{

    public MoneyManager moneyScript;

    public List<string> days = new List<string>() { "Ma", "Di", "Wo", "Do", "Vr", "Za", "Zo" };
    public string day;
    int dayNum;

    public int weekNum;

    public List<string> months = new List<string>() { "Jan", "Feb", "Mrt", "Apr", "Mei", "Jun", "Jul", "Aug", "Spt", "Okt", "Nov", "Dec" };
    public string month;
    int monthNum;

    public bool AllowNextDayBool;

    public bool eventBool;


    float clockTimer;
    public Text currentDateText;



    public int timeSpeed = 60;

    // Use this for initialization
    void Start()
    {
        weekNum = 1;
    }


    // Update is called once per frame
    void Update()
    {
        day = days[dayNum];
        month = months[monthNum];



        clockTimer += Time.deltaTime * timeSpeed;
        int seconds = (int)(clockTimer % 60);
        int minutes = (int)(clockTimer / 60) % 60;
        int hours = (int)(clockTimer / 3600) % 24;

        string CurrentTimeString = string.Format("{0:0}:{1:00}", hours, minutes);

        currentDateText.text = month + ", " + day + ", " + CurrentTimeString;


        //changes day, week and month with NextDay(), NextWeek(), NextMonth()
        if (hours == 23 && minutes == 59 && seconds == 59 && AllowNextDayBool == true)
        {
            NextDay();
            AllowNextDayBool = false;
            eventBool = false;
        }

        if (hours == 0 && minutes == 1 && seconds == 1)
        {
            AllowNextDayBool = true;
            eventBool = true;
        }


        if (dayNum == 3 && weekNum == 3 && eventBool == true)
        {
            eventBool = false;
            moneyScript.StudieFin();
        }
        if (dayNum == 2 && weekNum == 4 && eventBool == true)
        {
            eventBool = false;
            moneyScript.Loon();
        }
        if (dayNum == 0 && weekNum == 3 && eventBool == true)
        {
            eventBool = false;
            moneyScript.Belastingsdients();
        }
        if (dayNum == 5 && weekNum == 2 && eventBool == true)
        {
            eventBool = false;
            moneyScript.StudieBetalen();
        }
        if (dayNum == 1 && weekNum == 3 && eventBool == true)
        {
            eventBool = false;
            moneyScript.Zorgtoeslag();
        }
        if (dayNum == 4 && weekNum == 2 && eventBool == true)
        {
            eventBool = false;
            moneyScript.HuisHuur();
        }


    }

    void NextDay()
    {
        dayNum++;

        if (dayNum == 7)
        {
            dayNum = 0;
            NextWeek();
        }
    }

    void NextWeek()
    {
        weekNum++;
        if (weekNum == 5)
        {
            weekNum = 1;
            NextMonth();
        }
    }

    void NextMonth()
    {
        monthNum++;
        if (monthNum == 12) ;
    }


}
