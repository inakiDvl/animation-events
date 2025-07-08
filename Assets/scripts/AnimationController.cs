using System;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private const float crossFadeTime = 0.15f;

    private Animator animator;

    public event Action<AnimationData> OnAnimationPlayed;

    public void PlayAnimation(AnimationData animation)
    {
        animator.CrossFadeInFixedTime(animation.NameHash, crossFadeTime);
    }
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
}
