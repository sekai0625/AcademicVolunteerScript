using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class FinishText2 : MonoBehaviour
{
    public GameObject score2Object;
    Score2 score2Script;
    public GameObject objectManagerObject;
    ObjectManager2 objectManagerScript;
    public TextMeshProUGUI finishText; // 表示用テキストUI
    public float durationTIme = 0;
    public bool clearFlag = false;
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;

    void Start()
    {
        score2Object = GameObject.Find("Score");
        score2Script = score2Object.GetComponent<Score2>();
        objectManagerObject = GameObject.Find("ObjectManager2");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager2>();
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
            Debug.Log("point:" + score2Script.points);
            finishText.text = score2Script.points + "ポイントだよ！ \n すごい！よくがんばったね！";
        } 
        else if (durationTIme >= 10 && durationTIme < 13)
        {
            finishText.text = "つぎのゲームにいこう！";
            clearFlag = true;
        }
        else if (durationTIme >= 13)
        {
            Initiate.Fade("STEP3", fadeColor, fadeSpeedMultiplier);
        }
    }
}
