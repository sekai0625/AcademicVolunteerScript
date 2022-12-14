using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager3 : MonoBehaviour
{
    public GameObject tutorialObject;
    public GameObject clickSliderObject;
    public GameObject timerCanvasObject;
    public GameObject metalMatch1Object;
    public GameObject metalMatch2Object;
    public GameObject rodeObject;
    public GameObject collectRangeObject;
    public GameObject collisionBoxObject;
    public GameObject musicBoxObject;
    public GameObject score3Object;
    public GameObject finishObject;
    public GameObject bgmObject;
    public GameObject tutorialCanvasObject;
    public bool tutorialTextFinishFlag = false;

    void Start()
    {
        tutorialCanvasObject = GameObject.Find("TutorialCanvas");
        tutorialObject = GameObject.Find("Tutorial");
        timerCanvasObject = GameObject.Find("TimerCanvas");
        timerCanvasObject.SetActive(false);
        clickSliderObject = GameObject.Find("ClickSlider");
        metalMatch1Object = GameObject.Find("MetalMatch1");
        metalMatch2Object = GameObject.Find("MetalMatch2");
        rodeObject = GameObject.Find("Rode");
        rodeObject.SetActive(false);
        collectRangeObject = GameObject.Find("CollectRange");
        collectRangeObject.SetActive(false);
        collisionBoxObject = GameObject.Find("CollisionBox");
        collisionBoxObject.SetActive(false);
        musicBoxObject = GameObject.Find("MusicBox");
        musicBoxObject.SetActive(false);
        score3Object = GameObject.Find("Score3");
        finishObject = GameObject.Find("Finish");
        finishObject.SetActive(false);
        bgmObject = GameObject.Find("BGM");
    }

    // Update is called once per frame
    void Update()
    {
        if (tutorialTextFinishFlag)
        {
            tutorialCanvasObject.SetActive(false);
        }
    }
}
