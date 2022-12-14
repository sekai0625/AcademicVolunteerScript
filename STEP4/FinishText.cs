using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class FinishText : MonoBehaviour
{
    public GameObject gameSystemObject;
    public GameSystem gameSystemScript;
    public GameObject objectManagerObject;
    public ObjectManager4 objectManagerScript;
    public GameObject scoreObject;
    public Score4 score4Script;
    public TextMeshProUGUI finishText; // 表示用テキストUI
    public float durationTIme = 0;
    
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;

    void Start()
    {
        objectManagerObject = GameObject.Find("ObjectManager4");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager4>();
        gameSystemObject = GameObject.Find("GameSystem");
        gameSystemScript = gameSystemObject.GetComponent<GameSystem>();
        scoreObject = GameObject.Find("Score");
        score4Script = scoreObject.GetComponent<Score4>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameSystemScript.clearStatus)
        {
            durationTIme += Time.deltaTime;
            if (durationTIme >= 0 && durationTIme < 3)
            {
                finishText.text = "そこまで！";
            }
            else if (durationTIme >= 3 && durationTIme < 6)
            {
                finishText.text = "けっかは...";
            }
            else if (durationTIme >= 6 && durationTIme < 10)
            {
                finishText.text = score4Script.points + "ポイントだよ！ \n すごい！よくがんばったね！";
            }
            else if (durationTIme >= 10 & durationTIme < 13)
            {
                finishText.text = "さあ！ \n どんな料理が出てくるかな！";
            } 
            else if (durationTIme >= 13)
            {
                Initiate.Fade("STEP5-2", fadeColor, fadeSpeedMultiplier); // シーンチェンジ
            }
        }
        else
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
                finishText.text = score4Script.points + "ポイントだよ！ \n すごい！よく頑張ったね！";
            }
            else if (durationTIme >= 10 & durationTIme < 13)
            {
                finishText.text = "さあ！ \n どんな料理が出てくるかな！";
            } 
            else if (durationTIme >= 13)
            {
                Initiate.Fade("STEP5-2", fadeColor, fadeSpeedMultiplier); // シーンチェンジ
                // Initiate.Fade("STEP5", fadeColor, fadeSpeedMultiplier); // シーンチェンジ
                // SceneManager.LoadScene("STEP5");
            }
        }
    }
}
