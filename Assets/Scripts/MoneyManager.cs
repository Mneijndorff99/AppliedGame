using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{

    float startingMoney;

    public Text testMoney;

    public float studieFin;
    public float loon;
    public float belastingdienst;
    public float studieBetalen;
    public float zorgtoeslag;
    public float huisHuur;

    // Use this for initialization
    void Start()
    {
        startingMoney = 800f;
        studieFin = 487.11f;
        loon = Random.Range(250f, 300f);
        belastingdienst = 95f;
        studieBetalen = 189.90f;
        zorgtoeslag = 124.80f;
        huisHuur = 740f;
    }

    // Update is called once per frame
    void Update()
    {
        testMoney.text = "€" + " " + startingMoney;
    }

    public void StudieFin()
    {
        startingMoney = startingMoney + studieFin;
    }

    public void Loon()
    {
        startingMoney = startingMoney + loon;
    }

    public void Belastingsdients()
    {
        startingMoney = startingMoney + belastingdienst;
    }

    public void StudieBetalen()
    {
        startingMoney = startingMoney - studieBetalen;
    }

    public void Zorgtoeslag()
    {
        startingMoney = startingMoney - zorgtoeslag;
    }

    public void HuisHuur()
    {
        startingMoney = startingMoney - huisHuur;
    }


}