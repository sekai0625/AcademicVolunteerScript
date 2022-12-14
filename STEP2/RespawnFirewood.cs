using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFirewood : MonoBehaviour
{
    
    public GameObject camfireObject;
    public Vector3 campfireObjectPosition;
    private float dis;
    private Vector3 firewoodInitialPosition;
    private Quaternion firewoodInitialRotation;
    [SerializeField] float maxDis = 1.3f;

    void Start()
    {
        camfireObject = GameObject.Find("Campfire");
        campfireObjectPosition = camfireObject.transform.localPosition;
        firewoodInitialPosition = gameObject.transform.localPosition;
        firewoodInitialRotation = gameObject.transform.localRotation;
    }

    void Update()
    {
        dis = Vector3.Distance(campfireObjectPosition, gameObject.transform.localPosition);
        if (dis > maxDis)
        {
            Reset();
        }
        Debug.Log("distance:" + dis);
    }

    public void Reset()
    {
        gameObject.transform.localPosition = firewoodInitialPosition;
        gameObject.transform.localRotation = firewoodInitialRotation;
    }
}
