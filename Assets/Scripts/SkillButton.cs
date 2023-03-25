using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillButton : MonoBehaviour
{
    public float attackDelay;
    public float blockDelay;
    public float dashDelay;
    Animator anim;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackButton()
    {
        
    }

    public void BlockButton()
    {

    }

    public void DashButton()
    {

    }
}
