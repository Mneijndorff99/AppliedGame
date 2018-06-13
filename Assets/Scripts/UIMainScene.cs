using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainScene : MonoBehaviour {
    GameObject Menubtn;
    public GameObject MenuUI;

    public bool isPaused = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void Menu()
    {
        if (isPaused)
        {
            Resume();
        }
        else{
            Pause();
        }
    }


    public void Resume()
    {
        MenuUI.SetActive(false);
        isPaused = false;
    }

    public void Pause()
    {
        MenuUI.SetActive(true);
        isPaused = true;
    }
}
