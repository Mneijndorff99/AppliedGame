using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainScene : MonoBehaviour {
    GameObject Menubtn;
    public GameObject MenuUI;

    public GameObject foodTab;
    public GameObject furnitureTab;

    [SerializeField]List<string> Inventory;


    public bool menuOpend = false;

    public void Menu(GameObject ChooseMenu)
    {
        if (menuOpend)
        {
            ChooseMenu.SetActive(false);
            menuOpend = false;
        }
        else{
            ChooseMenu.SetActive(true);
            menuOpend = true;
        }
    }

    public void Price(int price)
    {
        PlayerManager.money = PlayerManager.money -price;
    }

    public void AddedFood(float addFoodTotal)
    {
        PlayerManager.FoodBar += addFoodTotal;
    }

    public void Foodtab()
    {
        foodTab.SetActive(true);
        furnitureTab.SetActive(false);
    }

    public void FurnitureTab()
    {
        furnitureTab.SetActive(true);
        foodTab.SetActive(false);
    }    
    
    public void AddFurniture(string furnitureName)
    {
        string name = furnitureName;

        switch (name)
        {
            case "Table":
                Inventory.Add("Table");
                break;
            case "Chair":
                Inventory.Add("Chair");
                break;
            case "Mirror":
                Inventory.Add("Mirror");
                break;
            case "Bed":
                Inventory.Add("Bed");
                break;
            case "TV":
                Inventory.Add("TV");
                break;
            case "Closet":
                Inventory.Add("Closet");
                break;
            case "Couch":
                Inventory.Add("Couch");
                break;
        }
    }
}
