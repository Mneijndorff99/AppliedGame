using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventScript : MonoBehaviour {

    public List<string> dagen = new List<string>() { "Ma", "Di", "Wo", "Do", "Vr", "Za", "Zo" };

    public string dag;

    int dagNummer;

    float clockTimer;
    public Text timeOfDay;

	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        clockTimer += Time.deltaTime*600;
        int seconds = (int)(clockTimer % 60);
        int minutes = (int)(clockTimer / 60) % 60;
        int hours = (int)(clockTimer / 3600) % 24;

        string timerString = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);

        timeOfDay.text = timerString;
        dag = dagen[dagNummer];


        if(hours == 23 && minutes == 59)
        {
            NextDay();
        }

	}

    void NextDay()
    {
        Debug.Log("werkt");
        dagNummer++;
        if (dagNummer == 6)
        {
            dagNummer = 0;
        }
        Debug.Log(dagNummer);
    }
}
