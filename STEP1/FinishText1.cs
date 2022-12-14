using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class FinishText1 : MonoBehaviour
{
    public GameObject scoreObject;
    Score1 score1Script;
    public GameObject objectManagerObject;
    ObjectManager1 objectManagerScript;
    public TextMeshProUGUI finishText; // 表示用テキストUI
    public float durationTIme = 0;

    void Start()
    {
        scoreObject = GameObject.Find("Score");
        score1Script = scoreObject.GetComponent<Score1>();
        objectManagerObject = GameObject.Find("ObjectManager1");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager1>();
    }

    // Update is called once per frame
    void Update()
    {
        durationTIme += Time.deltaTime;
        if (durationTIme >= 0 && durationTIme < 3)
        {
            finishText.text = "タイムアップ！！";
        }
        else if (durationTIme >= 3 && durationTIme < 6)
        {
            finishText.text = "けっかは...";
        }
        else if (durationTIme >= 6 && durationTIme < 10)
        {
            Debug.Log("point:" + score1Script.points);
            finishText.text = score1Script.points + "ポイントだよ！ \n すごい！よくがんばったね！";
        } 
        else if (durationTIme >= 10)
        {
            finishText.text = "つぎのゲームにいこう！";
            objectManagerScript.axeObject.SetActive(true);
            objectManagerScript.nextGameSwitchObject.SetActive(true);
        }
    }
}
