using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
    Animator anim;
    public ParticleSystem flame;

    void Start()
    {
        anim = GetComponent<Animator>();
        flame = GetComponentInChildren<ParticleSystem>();
        flame.Stop();
    }

    public void StartFlame()
    {
        if (flame.isStopped)
        {
            flame.Play();
        }
    }

    public void StopFlame()
    {
        flame.Stop();
    }
}
