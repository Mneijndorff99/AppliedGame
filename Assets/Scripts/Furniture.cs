using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour {

    public GameObject chooser;

    bool allReadyThere = false;

    public void InstMenu()
    {
        if(allReadyThere == false)
        {
            Instantiate(chooser, this.transform);
        }
        else
        {
            Close();
        }
    }

    public void Close()
    {
        Destroy(GameObject.Find("Chooser(Clone)"));
    }

    public void Health()
    {
        PlayerManager.foodBar += 10;
    }

    public void Mood()
    {
        PlayerManager.moodbar += 10;
    }
}
