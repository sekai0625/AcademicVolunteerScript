using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject udpSenderObject;
    UDPSender udpSenderScript;
    public GameObject objectManagerObject;
    ObjectManager1 objectManagerScript;
    public GameObject videoObject;
    public GameObject timerCanvasObject;
    public bool countDwonFlag = false;
    public bool collisionStatus = false;
    public AudioClip se;
    AudioSource au;

    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;

    void Start()
    {
        objectManagerObject = GameObject.Find("ObjectManager1");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager1>();
        videoObject = GameObject.Find("Step1Video");
        timerCanvasObject = GameObject.Find("TimerCanvas");
        udpSenderObject = GameObject.Find("UDPSender");
        udpSenderScript = udpSenderObject.GetComponent<UDPSender>();
        au = GetComponent<AudioSource>();
    }

    void Update()
    {
        objectManagerScript.nextSwitchObject.SetActive(true);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name.Contains("CapsuleRigidbody"))
        {
            if (OVRInput.IsControllerConnected(OVRInput.Controller.Hands)) // ハンドトラッキング
            {
                udpSenderScript.UDPSend(1); // 振動の送信
            }
            else if (OVRInput.IsControllerConnected(OVRInput.Controller.Touch)) // コントローラー
            {
                OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
            }
        }

        if (col.CompareTag("firewood"))
        {
            if (OVRInput.IsControllerConnected(OVRInput.Controller.Hands)) // ハンドトラッキング
            {
                udpSenderScript.UDPSend(3); // 振動の送信
            }
            else if (OVRInput.IsControllerConnected(OVRInput.Controller.Touch)) // コントローラー
            {
                OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
            }
            collisionStatus = true;
            au.PlayOneShot(se);
            // AudioSource.PlayClipAtPoint(se, transform.position);
            // Debug.Log("HIT");
        }

        if (col.CompareTag("STEP1_Next"))
        {
            if (OVRInput.IsControllerConnected(OVRInput.Controller.Hands)) // ハンドトラッキング
            {
                udpSenderScript.UDPSend(3); // 振動の送信
            }
            else if (OVRInput.IsControllerConnected(OVRInput.Controller.Touch)) // コントローラー
            {
                OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
            }
            au.PlayOneShot(se);
            // AudioSource.PlayClipAtPoint(se, transform.position);
            objectManagerScript.tutorialObject.SetActive(false);
            objectManagerScript.timerCanvasObject.SetActive(true);
        }

        if (col.CompareTag("STEP1_NextGame"))
        {
            if (OVRInput.IsControllerConnected(OVRInput.Controller.Hands)) // ハンドトラッキング
            {
                udpSenderScript.UDPSend(3); // 振動の送信
            }
            else if (OVRInput.IsControllerConnected(OVRInput.Controller.Touch)) // コントローラー
            {
                OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
            }
            au.PlayOneShot(se);
            // AudioSource.PlayClipAtPoint(se, transform.position);    
            Initiate.Fade("STEP2", fadeColor, fadeSpeedMultiplier);
            // Debug.Log("NextGame");  
        }
    }
}
