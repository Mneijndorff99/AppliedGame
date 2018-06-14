using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

    public static float FoodBar = 100;
    public static int money;

    public Slider foodSlider;



	// Update is called once per frame
	void Update () {
        FoodBar -= 1 * Time.deltaTime;
        foodSlider.value = FoodBar;
	}
}
