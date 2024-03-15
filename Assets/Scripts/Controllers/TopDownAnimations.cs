using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimations : MonoBehaviour
{
    protected Animator animator;
    protected TopDownCharacterController controller;

    protected virtual void Awake()
    {
        //애니메이션은 같은 곳에 설치
        //에니메이터는 하위에
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<TopDownCharacterController>();
    }
}