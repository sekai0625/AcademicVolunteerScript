using System.Collections.Generic;
using UnityEngine;
 
public class MusicBoxSlider : MonoBehaviour
{
    public GameObject[] grateCubes;
    public GameObject[] goodCubes;
    public GameObject[] badCubes;

    void Start()
    {
        grateCubes = GameObject.FindGameObjectsWithTag("STEP3_GratePoint");
        goodCubes = GameObject.FindGameObjectsWithTag("STEP3_GoodPoint");
        badCubes = GameObject.FindGameObjectsWithTag("STEP3_BadPoint");
        foreach (GameObject cube in grateCubes)
        {
            Transform cubeTransform = cube.transform;
            Vector3 pos = cubeTransform.localPosition;
            pos.x *= 0.1f;

            cubeTransform.localPosition = pos;
        }

        foreach (GameObject cube in goodCubes)
        {
            Transform cubeTransform = cube.transform;
            Vector3 pos = cubeTransform.localPosition;
            pos.x *= 0.1f;

            cubeTransform.localPosition = pos;
        }

        foreach (GameObject cube in badCubes)
        {
            Transform cubeTransform = cube.transform;
            Vector3 pos = cubeTransform.localPosition;
            pos.x *= 0.1f;

            cubeTransform.localPosition = pos;
        }
    }
    
    void Update()
    {
 
        //トランスフォームの取得
        Transform myTransform = this.transform;
 
        //座標の取得
        Vector3 pos = myTransform.localPosition;
 
        //x方向の速度
        pos.x -= 0.085f * 0.18f;
 
        //座標の設定
        myTransform.localPosition = pos;
    }
}