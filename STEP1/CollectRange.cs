using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectRange : MonoBehaviour
{
    public Material[] ColorSet = new Material[3];
    public GameObject ringImgObject;
    public GameObject collectRange;
    public GameObject axeObject;
    public GameObject scoreObject;
    public Score1 socre1Script;
    ScaleChange scaleChangeScript;
    CollisionDetection collisionDetectionScript;
    Vector3 scale;
    public AudioClip se1;
    // public AudioClip se2;
    AudioSource au;
    private int collectRangeStatus = 0; // 0:normal 1:collect 2:false

    void Start()
    {
        ringImgObject = GameObject.Find("RingImg");
        scaleChangeScript = ringImgObject.GetComponent<ScaleChange>();
        collectRange = GameObject.Find("Torus");
        axeObject = GameObject.Find("Axe");
        collisionDetectionScript = axeObject.GetComponent<CollisionDetection>();
        scoreObject = GameObject.Find("Socre");
        socre1Script = scoreObject.GetComponent<Score1>();
        au = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        scale = scaleChangeScript.transform.localScale;
        Debug.Log("ScaleXS: " + scale.x);
        
        // 成功範囲のリングの色の状態
        if (collectRangeStatus == 1)
        {
            StartCoroutine(ChangeCollectColor());
        }
        else if (collectRangeStatus == 2)
        {
            StartCoroutine(ChangeFalseColor());
            // au.PlayOneShot(se2);
        }
        else
        {
            collectRange.GetComponent<MeshRenderer>().material = ColorSet[0];
        }
        Debug.Log("(x, y) = (" + scale.x + ", " + scale.y + ")");
        if (scale.x >= 0.144f && scale.y >= 0.144f && scale.x <= 0.22f && scale.y <= 0.22f)
        {
            if (Input.GetKeyDown(KeyCode.Space) || collisionDetectionScript.collisionStatus)
            {
                // au.PlayOneShot(se1);
                Debug.Log("OK");
                collectRangeStatus = 1;
                socre1Script.points += 10;  
                // GetPoint();
                scaleChangeScript.m_duration -= 0.4f; // 成功するごとに円の縮まる速さを0.2早くする
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) || collisionDetectionScript.collisionStatus)
            {
                collectRangeStatus = 2;
            }
        }
    }

    private IEnumerator ChangeCollectColor()
    {
        collisionDetectionScript.collisionStatus = false;
        collectRange.GetComponent<MeshRenderer>().material = ColorSet[1];
        yield return new WaitForSeconds(0.5f); // 0.5秒停止（状態を維持）
        collectRangeStatus = 0;
        collectRange.GetComponent<MeshRenderer>().material = ColorSet[0];
    }

    private IEnumerator ChangeFalseColor()
    {
        collisionDetectionScript.collisionStatus = false;
        collectRange.GetComponent<MeshRenderer>().material = ColorSet[2];
        yield return new WaitForSeconds(0.5f); // 0.5秒停止（状態を維持）
        collectRangeStatus = 0;
        collectRange.GetComponent<MeshRenderer>().material = ColorSet[0];
    }

    // public void GetPoint()
    // {
    //     socre1Script.points += 10;
    // }
}
