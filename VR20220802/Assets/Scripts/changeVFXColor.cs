using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeVFXColor : MonoBehaviour
{
    public float arrangeRange = 0.5f;

    private ParticleSystem target;

    private void Awake()
    {
        target = GetComponent<ParticleSystem>();
    }
}
