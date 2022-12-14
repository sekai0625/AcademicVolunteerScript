using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDistance : MonoBehaviour
{

    public GameObject uchiwaObject;
    public Vector3 before;
    public Vector3 after;
    public float dis;
    public float total;
    [SerializeField] public float maxValue = 500;

    void Start()
    {
        before = uchiwaObject.transform.position;
        dis = 0;
        total = 0;
    }

    void Update()
    {
        after = uchiwaObject.transform.position;
        dis = Vector3.Distance(before, after);
        total += dis; 
        before = after;

    }
}
