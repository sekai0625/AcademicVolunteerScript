using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score4 : MonoBehaviour
{
    public GameObject gameSystemObject;
    GameSystem gameSystemScript;
    public int points = 0;
    public static int step4Points;

    void Start()
    {
        gameSystemObject = GameObject.Find("GameSystem");
        gameSystemScript = gameSystemObject.GetComponent<GameSystem>();
    }

    void Update()
    {
        points = gameSystemScript.point;
        step4Points = points;
    }

    public static int getPoints()
    {
        return step4Points;
    }
}
