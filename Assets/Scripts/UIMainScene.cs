using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainScene : MonoBehaviour {

    bool exitMenu = false;
    public GameObject exitMenuPanel;

    GameObject Menubtn;
    public GameObject MenuUI;
    [SerializeField] Dictionary<string, Button> inventoryButtons;
    Dictionary<string, GameObject> houseFurniture;

    public GameObject scrollview;
    public AudioSource audi;
    public Slider soundVolume;

    public GameObject foodTab;
    public GameObject furnitureTab;
    public GameObject assesorieTab;

    public GameObject infoPanel;

    [SerializeField]List<string> Inventory;

    private void Awake()
    {
        exitMenu = false;
        exitMenuPanel.SetActive(false);
        PlayerManager.foodBar = 100;
        PlayerManager.moodbar = 150;
        inventoryButtons = new Dictionary<string, Button>();
        houseFurniture = new Dictionary<string, GameObject>();

        inventoryButtons.Add("Table", GameObject.FindGameObjectWithTag("Table").GetComponent<Button>());
        inventoryButtons.Add("Chair", GameObject.FindGameObjectWithTag("Chair").GetComponent<Button>());
        inventoryButtons.Add("Mirror", GameObject.FindGameObjectWithTag("Mirror").GetComponent<Button>());
        inventoryButtons.Add("Bed", GameObject.FindGameObjectWithTag("Bed").GetComponent<Button>());
        inventoryButtons.Add("TV", GameObject.FindGameObjectWithTag("TV").GetComponent<Button>());
        inventoryButtons.Add("Closet", GameObject.FindGameObjectWithTag("Closet").GetComponent<Button>());
        inventoryButtons.Add("Couch", GameObject.FindGameObjectWithTag("Couch").GetComponent<Button>());

        scrollview.SetActive(false);
        houseFurniture.Add("TV", GameObject.FindGameObjectWithTag("TVBtn"));
        houseFurniture.Add("Bed", GameObject.FindGameObjectWithTag("BedBtn"));
        houseFurniture.Add("Table", GameObject.FindGameObjectWithTag("TableBtn"));
        houseFurniture.Add("Mirror", GameObject.FindGameObjectWithTag("MirrorBtn"));
        houseFurniture.Add("Chair", GameObject.FindGameObjectWithTag("ChairBtn"));
        houseFurniture.Add("Couch", GameObject.FindGameObjectWithTag("CouchBtn"));


        houseFurniture["TV"].SetActive(false);
        houseFurniture["Bed"].SetActive(false);
        houseFurniture["Table"].SetActive(false);
        houseFurniture["Chair"].SetActive(false);
        houseFurniture["Mirror"].SetActive(false);
        houseFurniture["Couch"].SetActive(false);

    }

    private void Start()
    {
        foreach (KeyValuePair<string, Button> item in inventoryButtons)
        {
            item.Value.interactable = false;
        }
    }

    private void Update()
    {
        audi.volume = soundVolume.value;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (exitMenu)
            {
                exitMenuPanel.SetActive(false);
                exitMenu = false;
            }
            else
            {
                exitMenuPanel.SetActive(true);
                exitMenu = true;
            }
        }
    }

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

    public void AddedFoodHealthy(float addFoodTotal)
    {
        PlayerManager.foodBar += addFoodTotal;
        PlayerManager.moodbar += addFoodTotal / 2;
    }

    public void AddedFoodUnhealthy(float addFoodTotal)
    {
        PlayerManager.foodBar -= addFoodTotal;
        PlayerManager.moodbar += addFoodTotal / 2;
    }

    public void Foodtab()
    {
        foodTab.SetActive(true);
        furnitureTab.SetActive(false);
        assesorieTab.SetActive(false);
    }

    public void FurnitureTab()
    {
        furnitureTab.SetActive(true);
        foodTab.SetActive(false);
        assesorieTab.SetActive(false);
    }    

    public void AssesorieTab()
    {
        assesorieTab.SetActive(true);
        furnitureTab.SetActive(false);
        foodTab.SetActive(false);
    }
    
    public void AddFurniture(string furnitureName)
    {
        string name = furnitureName;

        Inventory.Add(name);
        inventoryButtons[name].interactable = true;
        houseFurniture[name].SetActive(true);
    }

    public void ExitInfoPanel()
    {
        this.GetComponent<PlayerManager>().enabled = true;
        this.GetComponent<MoneyManager>().enabled = true;
        this.GetComponent<EventScript>().enabled = true;
        Destroy(infoPanel);
    }

}
