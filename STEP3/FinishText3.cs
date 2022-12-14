using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class FinishText3 : MonoBehaviour
{
    public GameObject objectManagerObject;
    ObjectManager3 objectManagerScript;
    public GameObject score3Object;
    Score3 score3Script;
    public GameObject gameSystem3Object;
    GameSystem3 gameSystem3Script;
    public TextMeshProUGUI finishText; // 表示用テキストUI
    public float durationTIme = 0;
    

    void Start()
    {
        objectManagerObject = GameObject.Find("ObjectManager");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager3>();
        score3Object = GameObject.Find("Score3");
        score3Script = score3Object.GetComponent<Score3>();
        gameSystem3Object = GameObject.Find("GameSystem3");
        gameSystem3Script = gameSystem3Object.GetComponent<GameSystem3>();
    }

    // Update is called once per frame
    void Update()
    {
            durationTIme += Time.deltaTime;
            if (durationTIme >= 0 && durationTIme < 3)
            {
                finishText.text = "よくがんばったね！";
            }
            else if (durationTIme >= 3 && durationTIme < 6)
            {
                finishText.text = "けっかは...";
            }
            else if (durationTIme >= 6 && durationTIme < 10)
            {
                finishText.text = score3Script.point + "ポイントだよ！ \n すごい！よくがんばったね！";
            }
            else if (durationTIme >= 10)
            {
                finishText.text = "メタルマッチをこすって、\n つぎのゲームにいこう！";
                gameSystem3Script.clearFlag = true;
                // objectManagerScript.nextGameSwitchObject.SetActive(true);
            }
    }
}
