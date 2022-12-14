using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager5_2 : MonoBehaviour
{
    private float elapsedTime = 0;
    [SerializeField] private float fadeInTime = 7;
    [SerializeField] private float socreShowTime = 25;
    public GameObject tripodObject;
    // public GameObject fadeInObject;
    public GameObject master1;
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;

    void Start()
    {
        tripodObject = GameObject.Find("Cooking_Tripod_2");
        // fadeInObject = GameObject.Find("FadeIn");
        master1 = GameObject.Find("Master1");

        // fadeInObject.SetActive(false);
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= fadeInTime)
        {
            Initiate.Fade("STEP6", fadeColor, fadeSpeedMultiplier); // シーンチェンジ
        }
        // else if (elapsedTime >= fadeInTime - 5)
        // {
        //     fadeInObject.SetActive(true);
        //     Debug.Log("fadeIn_true");
        // }
    }
}
