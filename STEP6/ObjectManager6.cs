using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager6 : MonoBehaviour
{
    [SerializeField] private float socreShowTime = 1;
    private float elapsedTime = 0;
    public GameObject foodObject;
    public GameObject stoneTableObject;
    public GameObject totalScoreCanvasObject;
    public GameObject master2;
    public GameObject sittingLogObject;
    
    void Start()
    {
        // totalScoreCanvasObject = GameObject.Find("TotalScoreCanvas");
        // totalScoreCanvasObject.SetActive(false);

    }

    void Update()
    {
        // elapsedTime += Time.deltaTime;
        // if (elapsedTime >= socreShowTime)
        // {
        //     totalScoreCanvasObject.SetActive(true);
        // }
    }
}
