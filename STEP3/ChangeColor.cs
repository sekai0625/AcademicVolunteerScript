using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
	[SerializeField] Color[] Colors;
    public GameObject metalMatch1Object;
    CollisionDetection3 collisionDetection3Script;

	Renderer Renderer;
	int CurrentColorIdx;
    private float timer;

	void Awake()
	{
		//何度も呼ぶAPIはキャッシュしておくといいです。
		Renderer = GetComponent<Renderer>();
		Renderer.material.color = Colors[0];
	}

    void Start()
    {
        metalMatch1Object = GameObject.Find("MetalMatch1");
        collisionDetection3Script = metalMatch1Object.GetComponent<CollisionDetection3>();
    }

	void Update()
    {
        if (collisionDetection3Script.changeColor)
        {
            timer += Time.deltaTime;
            if (timer <= 0.2)
            {
                Renderer.material.color = Colors[1];
            }
            else
            {
                Renderer.material.color = Colors[0];
                timer = 0;
                collisionDetection3Script.changeColor = false;
            }
        }
    }
}