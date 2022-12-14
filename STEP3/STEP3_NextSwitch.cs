using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STEP3_NextSwitch : MonoBehaviour
{
    public GameObject clickSliderObject;
    public Slider clickSlider;
    public GameObject objectManagerObject;
    ObjectManager3 objectManagerScript;

    void Start()
    {
        clickSliderObject = GameObject.Find("ClickSlider");
        clickSlider = clickSliderObject.GetComponent<Slider>();
        objectManagerObject = GameObject.Find("ObjectManager");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager3>();
    }

    void Update()
    {
        if (clickSlider.value >= clickSlider.maxValue)
        {
            objectManagerScript.tutorialObject.SetActive(false);
            objectManagerScript.tutorialTextFinishFlag = true;
            objectManagerScript.bgmObject.SetActive(false);
            clickSliderObject.SetActive(false);
            objectManagerScript.bgmObject.SetActive(false);
            objectManagerScript.timerCanvasObject.SetActive(true);
        }
    }
}
