using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score3 : MonoBehaviour
{
    public int point;
    public static int step3Points;

    void Start()
    {
        point = 0;
    }

    void Update()
    {
        step3Points = point;
    }

    public static int getPoints()
    {
        return step3Points;
    }
}
