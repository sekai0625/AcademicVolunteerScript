using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange5 : MonoBehaviour
{
    [SerializeField] private Color fadeColor = Color.white;
    [SerializeField] private float fadeSpeedMultiplier = 0.1f;
    [SerializeField] public float sceneChangeTime = 10;
    public float elapsedTime = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= sceneChangeTime)
        {
            Initiate.Fade("STEP6", fadeColor, fadeSpeedMultiplier); // シーンチェンジ
        }
    }
}
