using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score2 : MonoBehaviour
{
    public GameObject gameObjectObject;
    heights heightsScript;
    public int points = 0;
    public static int step2Points;
    public float h;

    void Start()
    {
        gameObjectObject = GameObject.Find("GameObject");
        heightsScript = gameObjectObject.GetComponent<heights>();
    }

    // Update is called once per frame
    void Update()
    {
        h = heightsScript.maxHeight * 2;
        if (h >= 0.4)
        {
            points = 100;
        }
        else if (h >= 0.3)
        {
            points = 80;
        }
        else if (h >= 0.25)
        {
            points = 60;
        }
        else if (h < 0.2)
        {
            points = 20;
        }
        step2Points = points;
    }

    public static int getPoints()
    {
        return step2Points;
    }
}
