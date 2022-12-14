using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public GameObject particleObject;
	void OnTriggerEnter(Collider col)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (col.CompareTag("STEP3_CollisionBox"))
		{
            Instantiate(particleObject, this.transform.position, Quaternion.identity);
			Destroy(gameObject, 0.01f);
		}
	}
}