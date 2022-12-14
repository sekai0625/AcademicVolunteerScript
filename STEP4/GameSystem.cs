using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    public GameObject objectManagerObject;
    ObjectManager4 objectManagerScript;
    public GameObject timerCanvasObject;
    public GameObject sliderObject;
    public Slider slider;
    public GameObject clickSliderObject;
    public Slider clickSlider;
    public GameObject uchiwaObject;
    public ObjectDistance objectDistanceScript;
    public ObjectDistanceForClick objectDistanceForClickScript;
    public GameObject videoObject;
    public GameObject nextObject;
    public float dis;
    public float clickDis;
    public float maxValue;
    public float clickSliderMaxValue;
    public float sliderValue;
    public bool clearStatus = false;
    public float countDownTime = 30;  // カウントダウンタイム
    public int point;

    void Start()
    {
        objectManagerObject = GameObject.Find("ObjectManager4");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager4>();
        videoObject = GameObject.Find("Step4Video");
        nextObject = GameObject.Find("NextSwitch");
        timerCanvasObject = GameObject.Find("TimerCanvas");
        uchiwaObject = GameObject.Find("uchiwa");
        objectDistanceScript = uchiwaObject.GetComponent<ObjectDistance>();
        objectDistanceForClickScript = uchiwaObject.GetComponent<ObjectDistanceForClick>();
    }

    // Update is called once per frame
    void Update()
    {
        if (objectManagerScript.gameTimerCanvasObject.activeSelf)
        {
            countDownTime -= Time.deltaTime;
        }

        if (objectManagerScript.clickSliderObject.activeSelf)
        {
            clickSliderObject = GameObject.Find("ClickSlider");
            clickSlider = clickSliderObject.GetComponent<Slider>();
            clickSliderMaxValue = clickSlider.maxValue;
            clickSlider.value += objectDistanceForClickScript.dis;
            // clickSlider.value = clickTotal;
            // Debug.Log("clickSliderValue:" + clickSlider.value);

            if (clickSlider.value >= clickSliderMaxValue)
            {
                nextObject.SetActive(false);
                videoObject.SetActive(false);
                objectManagerScript.clickSliderObject.SetActive(false);
                objectManagerScript.timerCanvasObject.SetActive(true);
                // objectManagerScript.axeObject.SetActive(false);
            }
        }

        if (objectManagerScript.sliderObject.activeSelf)
        {
            sliderObject = GameObject.Find("Slider");
            slider = sliderObject.GetComponent<Slider>();
            slider.value += objectDistanceScript.dis;
            clearStatus = true;
            point = (int)((slider.value / slider.maxValue) * 100); //
            Debug.Log(point);
            if (slider.value >= slider.maxValue || countDownTime < 1)
            {
                objectManagerScript.sliderObject.SetActive(false);
                objectManagerScript.gameTimerCanvasObject.SetActive(false);
                objectManagerScript.finishObject.SetActive(true);
            }
        }
    }
}
