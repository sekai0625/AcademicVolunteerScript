using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireParticleSystem : MonoBehaviour
{
    private ParticleSystem particle;
    public GameObject sliderObject;
    public Slider slider;

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        sliderObject = GameObject.Find("Slider");
        slider = sliderObject.GetComponent<Slider>();
    }

    void Update()
    {
        var main = particle.main;
        if (slider.value == slider.maxValue)
        {
            main.startSize = 1.5f;
        }
        else if (slider.value >= slider.maxValue * 4 / 5)
        {
            main.startSize = 1.0f;
        }
        else if (slider.value >= slider.maxValue * 3 / 5)
        {
            main.startSize = 0.7f;
        }
        else if (slider.value >= slider.maxValue * 2 / 5)
        {
            main.startSize = 0.5f;
        }
        else if (slider.value >= slider.maxValue * 1 / 5)
        {
            main.startSize = 0.3f;
        }
        else
        {
            main.startSize = 0.1f;
        }
    }
}
