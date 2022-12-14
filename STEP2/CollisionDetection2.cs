using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection2 : MonoBehaviour
{
    public GameObject udpSenderObject;
    UDPSender udpSenderScript;
    public GameObject objectManagerObject;
    ObjectManager2 objectManagerScript;

    void Start()
    {
        objectManagerObject = GameObject.Find("ObjectManager2");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager2>();
        udpSenderObject = GameObject.Find("UDPSender");
        udpSenderScript = udpSenderObject.GetComponent<UDPSender>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Firewood (1)" || col.gameObject.name == "Firewood (2)" || col.gameObject.name == "Firewood (3)")
        {
            // objectManagerScript.startFirewoodObject.SetActive(false);
            objectManagerScript.tutorialObject.SetActive(false);
            objectManagerScript.timerCanvasObject.SetActive(true);
        }
        
        // ここが掴んだときのイベント
        // if (col.gameObject.name.Contains("CapsuleRigidbody"))
        // {
        //     if (OVRInput.IsControllerConnected(OVRInput.Controller.Hands)) // ハンドトラッキング
        //     {
        //         udpSenderScript.UDPSend(1); // 振動の送信
        //     }
        //     else if (OVRInput.IsControllerConnected(OVRInput.Controller.Touch)) // コントローラー
        //     {
        //         OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
        //     }
        // }
    }
}