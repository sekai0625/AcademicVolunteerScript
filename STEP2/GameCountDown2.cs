using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class GameCountDown2 : MonoBehaviour
{
    public GameObject objectManagerObject;
    ObjectManager2 objectManagerScript;
    public static float countDownTime = 30;  // カウントダウンタイム
    public TextMeshProUGUI textCountDown; // 表示用テキストUI
    public bool finishTextFlag = false;

    // Use this for initialization
    void Start()
    {
        objectManagerObject = GameObject.Find("ObjectManager2");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager2>();
    }

    // Update is called once per frame
    void Update()
    {

        textCountDown.text = "のこり" + ((int)countDownTime).ToString("0") + "秒";
        countDownTime -= Time.deltaTime;

        // 0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）
        if (countDownTime <= 0F)
        {
            textCountDown.text = "";
            countDownTime = 0.0F;
            // objectManagerScript.gameSystemObject.SetActive(false);
            // objectManagerScript.gameObject1.SetActive(false);
            objectManagerScript.finishObject.SetActive(true);
            this.gameObject.SetActive(false);
        }

    }
}