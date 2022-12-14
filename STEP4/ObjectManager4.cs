using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager4 : MonoBehaviour
{
    public GameObject axeObject;
    public GameObject tutorialObject;
    public GameObject timerCanvasObject;
    public GameObject gameTimerCanvasObject;
    public GameObject finishObject;
    // public GameObject nextGameSwitchObject;
    public GameObject sliderObject;
    public GameObject clickSliderObject;
    public GameObject uchiwaObject;
    public GameObject fireLightObject;
    
    void Start()
    {
        // axeObject = GameObject.Find("Axe");
        fireLightObject = GameObject.Find("Fire light");
        fireLightObject.SetActive(false);
        tutorialObject = GameObject.Find("Tutorial");
        timerCanvasObject = GameObject.Find("TimerCanvas");
        timerCanvasObject.SetActive(false);
        gameTimerCanvasObject = GameObject.Find("GameTimerCanvas");
        gameTimerCanvasObject.SetActive(false);
        sliderObject = GameObject.Find("Slider");
        sliderObject.SetActive(false);
        clickSliderObject = GameObject.Find("ClickSlider");
        uchiwaObject = GameObject.Find("uchiwa");
        finishObject = GameObject.Find("Finish");
        finishObject.SetActive(false);
        // nextGameSwitchObject = GameObject.Find("NextGameSwitch");
        // nextGameSwitchObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
