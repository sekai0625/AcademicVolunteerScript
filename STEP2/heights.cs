// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class heights : MonoBehaviour
{
    // public GameObject 
    public float maxHeight = 0;
    // Start is called before the first frame update
    // void Start()
    // {
    //     GetComponent
    // }

    // Update is called once per frame
    void Update()
    {
        GameObject[] woods = GameObject.FindGameObjectsWithTag("firewood");
        maxHeight = 0;
        
        foreach (GameObject wood in woods) {
            Transform myTransform = wood.transform;
            Vector3 pos = myTransform.position;
            if (maxHeight < pos.y)
            {
                maxHeight = pos.y;
            }
        }
        Debug.Log("maxHeight:" + maxHeight);
    }
}
