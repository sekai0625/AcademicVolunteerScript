using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript3 : MonoBehaviour
{

    public GameObject objectManagerObject;
    ObjectManager3 objectManagerScript;
	public AudioClip audioSound;
	private AudioSource audioSource;

	void Start ()
    {
        objectManagerObject = GameObject.Find("ObjectManager");
        objectManagerScript = objectManagerObject.GetComponent<ObjectManager3>();
        audioSource = gameObject.GetComponent<AudioSource> ();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!audioSource.isPlaying)
        {
            objectManagerScript.rodeObject.SetActive(false);
            objectManagerScript.collectRangeObject.SetActive(false);
            objectManagerScript.collisionBoxObject.SetActive(false);
            objectManagerScript.musicBoxObject.SetActive(false);
            objectManagerScript.finishObject.SetActive(true);
        }
	}
}