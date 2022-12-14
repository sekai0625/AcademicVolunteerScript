using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class TotalScore : MonoBehaviour
{
    private float step1;
    private float step2;
    private float step3;
    private float step4;
    private float totalScore;
    public TextMeshProUGUI totalScoreText; // 表示用テキストUI
    private float elapsedTime = 0;
    [SerializeReference] private float textShowTime = 3;
    
    void Start()
    {

        step1 = Score1.getPoints();
        step2 = Score2.getPoints();
        step3 = Score3.getPoints();
        step4 = Score4.getPoints();
        totalScore = step1 + step2 + step3 + step4;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= textShowTime)
        {
            totalScoreText.text = "スコア \n " + totalScore + "ポイント！ \n きみのレベルは達人級だ！";
        }
    }
}
