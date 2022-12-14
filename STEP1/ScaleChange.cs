using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class ScaleChange : MonoBehaviour
{
    [SerializeField] public float m_duration = 0; // スケール演出の再生時間（秒）
    [SerializeField] public float m_from     = 0; // スケール演出の開始値
    [SerializeField] public float m_to       = 0; // スケール演出の終了値
    private float m_elapedTime;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_elapedTime += Time.deltaTime;
        var amount = m_elapedTime % m_duration / m_duration;
        var scale  = Mathf.Lerp( m_from, m_to, amount );
        transform.localScale = new Vector3( scale, scale, 1 );
        // Debug.Log("scaleX:" + transform.localScale.x);
    }
}
