using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class CountDown : MonoBehaviour
{
    public GameObject objectManagerObject;
    ObjectManager4 objectManagerScript;
    public static float countDownTime;  // カウントダウンタイム
    public float waitingTime; // カウント始めるまでの待ち時間
    public bool startCountDown = false;
    public TextMeshProUGUI textCountDown; // 表示用テキストUI

    void Start()
    {
        objectManagerObject = GameObject.Find("ObjectManager4");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager4>();

        waitingTime = 0;
        countDownTime = 4;
    }

    // Update is called once per frame
    void Update()
    {
        textCountDown.text = "ゲーム開始まで \n ";
        waitingTime += Time.deltaTime;

        if (waitingTime >= 2)
        {
            startCountDown = true;
        }

        if (startCountDown)
        {
            textCountDown.text = textCountDown.text = "ゲーム開始まで \n" + ((int)countDownTime).ToString("0");
            countDownTime -= Time.deltaTime;
        }

        // 0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）
        if (countDownTime <= 1F)
        {
            textCountDown.text = "";
            countDownTime = 0.0F;
            objectManagerScript.sliderObject.SetActive(true);
            objectManagerScript.gameTimerCanvasObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}