using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System.Text;

public class CollisionDetectionForUDP : MonoBehaviour
{
    public GameObject objectManagerObject;
    ObjectManager1 objectManagerScript;
    public GameObject videoObject;
    public GameObject nextObject;
    public GameObject timerCanvasObject;
    public bool countDwonFlag = false;
    public bool collisionStatus = false;
    public string host = "127.0.0.1";
    public int port = 3333;
    private UdpClient client;

    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;

    void Start()
    {
        objectManagerObject = GameObject.Find("ObjectManager1");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager1>();
        videoObject = GameObject.Find("Step1Video");
        nextObject = GameObject.Find("NextSwitch");
        timerCanvasObject = GameObject.Find("TimerCanvas");  
        client = new UdpClient();
        client.Connect(host, port);  
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(collisionStatus);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("firewood"))
        {
            // Debug.Log("HIT");
            collisionStatus = true;
            int mode = 1;
            byte[] dgram = Encoding.UTF8.GetBytes(mode.ToString());
            client.Send(dgram, dgram.Length);
        }

        if (col.CompareTag("STEP1_Next"))
        {
            nextObject.SetActive(false);
            videoObject.SetActive(false);
            objectManagerScript.timerCanvasObject.SetActive(true);
        }

        if (col.CompareTag("STEP1_NextGame"))
        {
            Initiate.Fade("STEP2", fadeColor, fadeSpeedMultiplier);
            // Debug.Log("NextGame");  
        }
    }
}
