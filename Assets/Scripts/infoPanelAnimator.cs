﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoPanelAnimator : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void playSlide()
    {
        anim.Play("infoAnimator");
    }
    public void closeSlide()
    {
        anim.Play("infoAnimatorReverse");
    }
}
