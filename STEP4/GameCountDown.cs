using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class GameCountDown : MonoBehaviour
{
    public GameObject objectManagerObject;
    ObjectManager4 objectManagerScript;
    public TextMeshProUGUI textCountDown; // 表示用テキストUI
    public bool finishTextFlag = false;
    public GameObject gameSystemObject;
    GameSystem gameSystemScript;

    // Use this for initialization
    void Start()
    {
        objectManagerObject = GameObject.Find("ObjectManager4");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager4>();
        gameSystemObject = GameObject.Find("GameSystem");
        gameSystemScript = gameSystemObject.GetComponent<GameSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        objectManagerScript.fireLightObject.SetActive(true);
        textCountDown.text = "のこり" + ((int)gameSystemScript.countDownTime).ToString("0") + "秒";

        // 0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）
        if (gameSystemScript.countDownTime <= 0F)
        {
            textCountDown.text = "";
            objectManagerScript.finishObject.SetActive(true);
            this.gameObject.SetActive(false);
        }

    }
}