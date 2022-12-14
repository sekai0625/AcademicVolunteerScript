using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDistanceForClick : MonoBehaviour
{
    public GameObject uchiwaObject;
    public Vector3 before;
    public Vector3 after;
    public float dis;
    public float total;

    void Start()
    {
        before = uchiwaObject.transform.position;
        dis = 0;
        total = 0;
    }

    // Update is called once per frame
    void Update()
    {
        after = uchiwaObject.transform.position;
        dis = Vector3.Distance(before, after);
        total += dis;
        before = after;
    }
}
