using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager1 : MonoBehaviour
{
    public GameObject axeObject;
    public GameObject tutorialObject;
    public GameObject gameObject1;
    public GameObject gameSystemObject;
    public GameObject timerCanvasObject;
    public GameObject gameTimerCanvasObject;
    public GameObject finishObject;
    public GameObject nextGameSwitchObject;
    public GameObject nextSwitchObject;
    private float elapsedTime = 0;
    [SerializeField] private float nextSwitchObjectShowTime = 10;
    private bool calledOnece = false;
    
    void Start()
    {
        axeObject = GameObject.Find("Axe");
        tutorialObject = GameObject.Find("Tutorial");
        gameSystemObject = GameObject.Find("GameSystem");
        gameSystemObject.SetActive(false);
        gameObject1 = GameObject.Find("GameObject");
        // gameObject1.SetActive(false);
        timerCanvasObject = GameObject.Find("TimerCanvas");
        timerCanvasObject.SetActive(false);
        gameTimerCanvasObject = GameObject.Find("GameTimerCanvas");
        gameTimerCanvasObject.SetActive(false);
        finishObject = GameObject.Find("Finish");
        finishObject.SetActive(false);
        nextGameSwitchObject = GameObject.Find("NextGameSwitch");
        nextGameSwitchObject.SetActive(false);
        nextSwitchObject = GameObject.Find("NextSwitch");
        nextSwitchObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= nextSwitchObjectShowTime && !calledOnece)
        {
            nextSwitchObject.SetActive(true);
            calledOnece = true;
        }
    }
}