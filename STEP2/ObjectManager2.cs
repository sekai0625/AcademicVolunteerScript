using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager2 : MonoBehaviour
{
    public GameObject tutorialObject;
    public GameObject gameObject1;
    public GameObject startFirewoodObject;
    public GameObject gameSystemObject;
    public GameObject timerCanvasObject;
    public GameObject gameTimerCanvasObject;
    public GameObject finishObject;
    public FinishText2 finishText2Script;
    public GameObject nextGameSwitchObject;
    
    void Start()
    {
        startFirewoodObject = GameObject.Find("StartFirewoodOB");
        tutorialObject = GameObject.Find("Tutorial");
        // gameSystemObject = GameObject.Find("GameSystem");
        // gameSystemObject.SetActive(false);
        // gameObject1 = GameObject.Find("GameObject");
        // gameObject1.SetActive(false);
        timerCanvasObject = GameObject.Find("TimerCanvas");
        timerCanvasObject.SetActive(false);
        gameTimerCanvasObject = GameObject.Find("GameTimerCanvas");
        gameTimerCanvasObject.SetActive(false);
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