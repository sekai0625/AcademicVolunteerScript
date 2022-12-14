using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager5 : MonoBehaviour
{
    private float elapsedTime = 0;
    [SerializeField] private float fadeInTime = 15;
    [SerializeField] private float socreShowTime = 25;
    public GameObject tripodObject;
    public GameObject foodObject;
    public GameObject stoneTableObject;
    public GameObject totalScoreCanvasObject;
    public GameObject fadeInObject;
    public GameObject fadeOutObject; 
    public GameObject master1;
    public GameObject master2;
    public GameObject sittingLogObject;
    
    void Start()
    {
        tripodObject = GameObject.Find("Cooking_Tripod_2");
        foodObject = GameObject.Find("Food");
        stoneTableObject = GameObject.Find("StoneTable_LOD");
        fadeInObject = GameObject.Find("FadeIn");
        fadeOutObject = GameObject.Find("FadeOut");
        totalScoreCanvasObject = GameObject.Find("TotalScoreCanvas");
        master1 = GameObject.Find("Master1");
        master2 = GameObject.Find("Master2");
        sittingLogObject = GameObject.Find("SittingLog");

        stoneTableObject.SetActive(false);
        foodObject.SetActive(false);
        fadeInObject.SetActive(false);
        fadeOutObject.SetActive(false);
        totalScoreCanvasObject.SetActive(false);
        master2.SetActive(false);
        sittingLogObject.SetActive(false);

    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= socreShowTime)
        {
            totalScoreCanvasObject.SetActive(true);
        }
        else if (elapsedTime >= fadeInTime + 2)
        {
            master1.SetActive(false);
            master2.SetActive(true);
            sittingLogObject.SetActive(true);
            fadeInObject.SetActive(false);
            tripodObject.SetActive(false);
            foodObject.SetActive(true);
            stoneTableObject.SetActive(true);
            Debug.Log("fadeIn_faluse");
            Debug.Log("fadeOut_true");
        }
        else if (elapsedTime >= fadeInTime)
        {
            fadeOutObject.SetActive(true);
        }
        else if (elapsedTime >= fadeInTime - 5)
        {
            fadeInObject.SetActive(true);
            Debug.Log("fadeIn_true");
        }
    }
}
