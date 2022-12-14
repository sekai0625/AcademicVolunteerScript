using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public GameObject videoObject;
    public GameObject nextObject;
    public GameObject timerCanvasObject;
    public bool countDwonFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        videoObject = GameObject.Find("Step4Video");
        nextObject = GameObject.Find("NextBox");
        timerCanvasObject = GameObject.Find("TimerCanvas");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("NextBox"))
        {
            // this.gameObject.SetActive(false);
            videoObject.SetActive(false);
            nextObject.SetActive(false);
            timerCanvasObject.SetActive(true);
            countDwonFlag = true;
            Debug.Log("Next");
        }
    }
}
