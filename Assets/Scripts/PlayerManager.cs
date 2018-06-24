using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

    public static float foodBar = 100;
    public static float moodbar = 150;
    public static int money;


    int happyNessDown = 1;

    public Slider foodSlider;
    public Slider moodSlider;

    public Sprite happy;
    public Sprite mweh;
    public Sprite sad;

    public Image disPlayMood;

    // Update is called once per frame
    void Update () {

        foodBar -= 1 * Time.deltaTime;
        foodSlider.value = foodBar;

        moodbar -= happyNessDown * Time.deltaTime;
        moodSlider.value = moodbar;
        if(foodBar > 100)
        {
            foodBar = 100;
        }

        if(moodbar > 150)
        {
            moodbar = 150;
        }
        if(moodbar > 120)
        {
            happyNessDown = 1;
            disPlayMood.sprite = happy;
        }
        if(moodbar < 120 && foodBar > 30)
        {
            happyNessDown = 2;
            disPlayMood.sprite = mweh;
        }
        if (moodbar < 30)
        {
            happyNessDown = 3;
            disPlayMood.sprite = sad;
        }

        if(foodBar <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
