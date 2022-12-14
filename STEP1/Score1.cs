using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score1 : MonoBehaviour
{
    // private GameObject collectRangeObject;
    // CollectRange collectRangeScript;

    public int points = 0;
    public static int step1Points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        step1Points = points;
        // collectRangeObject = GameObject.Find("Torus");
        // collectRangeScript = collectRangeObject.GetComponent<CollectRange>();
    }

    public static int getPoints()
    {
        return step1Points;
    }
}
