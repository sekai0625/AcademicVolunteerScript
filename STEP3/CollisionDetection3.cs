using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionDetection3 : MonoBehaviour
{
    public GameObject udpSenderObject;
    UDPSender udpSenderScript;
    public GameObject objectManagerObject;
    ObjectManager3 objectManagerScript;
    public GameObject metalMatch1Object;
    public GameObject metalMatch2Object;
    public GameObject collisionBoxObject;
    public GameObject clickSliderObject;
    public Slider clickSlider;
    public GameObject score3Object;
    Score3 score3Script;
    public GameObject gameSystem3Object;
    GameSystem3 gameSystem3Script;
    public bool changeColor;
    public AudioClip se;
    // AudioClip再生用
    AudioSource audiosource1;

    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;

    [SerializeField] public float elapsedTimeValue = 0.1f; // ノーツを消すオブジェクトの出現時間
    public float elapsedTime;

    void Start()
    {
        objectManagerObject = GameObject.Find("ObjectManager");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager3>();
        clickSliderObject = GameObject.Find("ClickSlider");
        clickSlider = clickSliderObject.GetComponent<Slider>();
        score3Object = GameObject.Find("Score3");
        score3Script = score3Object.GetComponent<Score3>();
        gameSystem3Object = GameObject.Find("GameSystem3");
        gameSystem3Script = gameSystem3Object.GetComponent<GameSystem3>();
        audiosource1 = GetComponent<AudioSource>();
        udpSenderObject = GameObject.Find("UDPSender");
        udpSenderScript = udpSenderObject.GetComponent<UDPSender>();
        elapsedTime = elapsedTimeValue;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // void OnTriggerStay(Collider col)
    // {
    //     if (col.CompareTag("MetalMatch"))
    //     {
    //         objectManagerScript.collisionBoxObject.SetActive(true);
    //     }
    // }

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
        
        // ここが掴んだときのイベント
        if (col.CompareTag("MetalMatch"))
        {
            if (OVRInput.IsControllerConnected(OVRInput.Controller.Hands)) // ハンドトラッキング
            {
                udpSenderScript.UDPSend(1); // 振動の送信
            }
            else if (OVRInput.IsControllerConnected(OVRInput.Controller.Touch)) // コントローラー
            {
                OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.RTouch);
            }
            // udpSenderScript.UDPSend(1); // 振動の送信
            audiosource1.PlayOneShot(se);
            changeColor = true;
            objectManagerScript.collisionBoxObject.SetActive(true);
            elapsedTime -= Time.deltaTime;
        }

        // ゲーム中のメタルマッチの当たり判定の処理
        if (col.CompareTag("STEP3_GratePoint"))
        {
            Debug.Log("Grate");
            score3Script.point += 50;
            objectManagerScript.collisionBoxObject.SetActive(false);
            // if (elapsedTime < 0)
            // {
            //     objectManagerScript.collisionBoxObject.SetActive(false);
            //     elapsedTime = elapsedTimeValue;
            // }
            // else
            // {
            //     elapsedTime -= Time.deltaTime;
            // }
        }
        else if (col.CompareTag("STEP3_GoodPoint"))
        {
            Debug.Log("Good");
            score3Script.point += 10;
            objectManagerScript.collisionBoxObject.SetActive(false);
            // if (elapsedTime < 0)
            // {
            //     objectManagerScript.collisionBoxObject.SetActive(false);
            //     elapsedTime = elapsedTimeValue;
            // }
            // else
            // {
            //     elapsedTime -= Time.deltaTime;
            // }
        }
        else if (col.CompareTag("STEP3_BadPoint"))
        {
            Debug.Log("Bad");
            score3Script.point -= 10;
            objectManagerScript.collisionBoxObject.SetActive(false);
            // if (elapsedTime < 0)
            // {
            //     objectManagerScript.collisionBoxObject.SetActive(false);
            //     elapsedTime = elapsedTimeValue;
            // }
            // else
            // {
            //     elapsedTime -= Time.deltaTime;
            // }
        }
        else
        {
            // Debug.Log("Miss");
            if (elapsedTime < 0)
            {
                objectManagerScript.collisionBoxObject.SetActive(false);
                elapsedTime = elapsedTimeValue;
            }
        }

        // チュートリアルのゲーム開始の処理
        if (objectManagerScript.clickSliderObject.activeSelf)
        {
            if (col.CompareTag("MetalMatch"))
            {
                clickSlider.value++;
            }
        }

        // ゲーム終了後の処理
        if (gameSystem3Script.clearFlag)
        {
            // SceneManager.LoadScene("STEP4"); // シーンチェンジ
            Initiate.Fade("STEP4", fadeColor, fadeSpeedMultiplier); // シーンチェンジ
            objectManagerScript.finishObject.SetActive(false);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("MetalMatch"))
        {
            objectManagerScript.collisionBoxObject.SetActive(false);
            // Debug.Log("CollisionBox_False");
        }
    }
}
