using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

    float startingMoney;

	// Use this for initialization
	void Start () 
    {
        startingMoney = 800f;
	}
	
	// Update is called once per frame


    public void StudieFin()
    {
        startingMoney = startingMoney + 487.11f;
    }

    public void Loon()
    {
        startingMoney = startingMoney + 294.60f;
    }

    public void Belastingsdients()
    {
        startingMoney = startingMoney + 95f;
    }

    public void StudieBetalen()
    {
        startingMoney = startingMoney - 189.90f;
    }

    public void Zorgtoeslag()
    {
        startingMoney = startingMoney - 124.80f;
    }

    public void HuisHuur()
    {
        startingMoney = startingMoney - 740f;
    }


}
