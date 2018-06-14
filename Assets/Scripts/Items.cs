using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {
    string itemName;
    public ItemType itemType;
    int price;
    int addValue;

    public enum ItemType {
        food,
        furniture, 
        animals
    }

    public Items(string name, int cost, int value, ItemType type)
    {
        itemName = name;
        price = cost;
        addValue = value;

    }
}
