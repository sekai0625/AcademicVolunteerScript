using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection4 : MonoBehaviour
{
    public GameObject udpSenderObject;
    UDPSender udpSenderScript;
    public GameObject objectManager4Object;
    ObjectManager4 objectManager4Script;
    public GameObject videoObject;
    public GameObject nextObject;
    public GameObject timerCanvasObject;
    public bool countDwonFlag = false;
    public bool collisionStatus = false;
    // Start is called before the first frame update
    void Start()
    {
        objectManager4Object = GameObject.Find("ObjectManager4");
        objectManager4Script = objectManager4Object.GetComponent<ObjectManager4>();
        videoObject = GameObject.Find("Step4Video");
        nextObject = GameObject.Find("NextSwitch");
        timerCanvasObject = GameObject.Find("TimerCanvas");
        udpSenderObject = GameObject.Find("UDPSender");
        udpSenderScript = udpSenderObject.GetComponent<UDPSender>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(collisionStatus);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name.Contains("CapsuleRigidbody"))
        {
            if (OVRInput.IsControllerConnected(OVRInput.Controller.Hands)) // ハンドトラッキング
            {
                udpSenderScript.UDPSend(3); // 振動の送信
            }
            else if (OVRInput.IsControllerConnected(OVRInput.Controller.Touch)) // コントローラー
            {
                OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
            }
        }
        // if (col.CompareTag("STEP4_Next"))
        // {
        //     nextObject.SetActive(false);
        //     videoObject.SetActive(false);
        //     objectManager4Script.timerCanvasObject.SetActive(true);
        //     objectManager4Script.axeObject.SetActive(false);
        //     countDwonFlag = true;
        //     Debug.Log("Next");
        // }

        // if (col.CompareTag("STEP4_NextGame"))
        // {
        //     Debug.Log("NextGame");
        // }
    }
}
