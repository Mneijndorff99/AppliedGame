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

    public Text eventText;
    int differentText;


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

        //reset
        if (hours == 0 && minutes == 1 && seconds == 1)
        {
            AllowNextDayBool = true;
            eventBool = true;
        }

        //reset event text
        if (hours == 0 && minutes == 9 && seconds == 59)
        {
            eventText.text = " ";
        }
        //events
        if (dayNum == 3 && weekNum == 3 && eventBool == true)
        {
            eventBool = false;
            moneyScript.StudieFin();
            differentText = 1;
            DisplayTextMessage();
        }
        if (dayNum == 2 && weekNum == 4 && eventBool == true)
        {
            eventBool = false;
            moneyScript.Loon();
            differentText = 2;
            DisplayTextMessage();
        }
        if (dayNum == 0 && weekNum == 3 && eventBool == true)
        {
            eventBool = false;
            moneyScript.Belastingsdients();
            differentText = 3;
            DisplayTextMessage();
        }
        if (dayNum == 5 && weekNum == 2 && eventBool == true)
        {
            eventBool = false;
            moneyScript.StudieBetalen();
            differentText = 4;
            DisplayTextMessage();

        }
        if (dayNum == 1 && weekNum == 3 && eventBool == true)
        {
            eventBool = false;
            moneyScript.Zorgtoeslag();
            differentText = 5;
            DisplayTextMessage();

        }
        if (dayNum == 4 && weekNum == 2 && eventBool == true)
        {
            eventBool = false;
            moneyScript.HuisHuur();
            differentText = 6;
            DisplayTextMessage();

        }

        if (dayNum == 6 && weekNum == 2 && eventBool == true)
        {
            eventBool = false;
            Debug.Log("Je bent nu halverwegen de eerste maand, Hoeveel geld denk je op het moment nog te hebben?");

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


    void DisplayTextMessage()
    {
        switch (differentText)
        {
            case 1:
                eventText.color = Color.green;
                eventText.text = "You recieved your college money for this month +" + moneyScript.studieFin;
                break;
            case 2:
                eventText.color = Color.green;
                eventText.text = "You recieved your salary of this month +" + moneyScript.loon.ToString("F2");
                break;
            case 3:
                eventText.color = Color.green;
                eventText.text = "You recieved your care allowens of this month +" + moneyScript.belastingdienst;
                break;
            case 4:
                eventText.color = Color.red;
                eventText.text = "You payed for your college for this month +" + moneyScript.loon;
                break;
            case 5:
                eventText.color = Color.red;
                eventText.text = "You payed for your care allowens for this month +" + moneyScript.zorgtoeslag;
                break;
            case 6:
                eventText.color = Color.red;
                eventText.text = "You payed your rent of this month +" + moneyScript.huisHuur;
                break;
        }
    }
}