using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {
   
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("Menu");
    }


}
