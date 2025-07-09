using System;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Temporal fields for playing an animation.
    public AnimationData animationData; 
    public bool playAnimation = false;

    [SerializeField] private Animator animator;
    [SerializeField] private List<AnimationEventTriggerer> triggerers = new();

    private const float crossFadeTime = 0.15f;

    public void PlayAnimation(AnimationData animation)
    {
        // animator.CrossFadeInFixedTime(animation.NameHash, crossFadeTime);
        CheckTriggerers(animation);
    }

    private void CheckTriggerers(AnimationData animation)
    {
        bool foundMatchingId = false;

        foreach (var triggerer in triggerers)
        {
            int triggererId = triggerer.GetId();

            if (foundMatchingId)
            {
                triggerer.TriggerEvent();
                break;
            }

            foreach (var animationEvent in animation.AnimationEvents)
            {
                int animationEventId = animationEvent.Id;

                if (triggererId == animationEventId)
                    foundMatchingId = true;
            }
        }
    }

    private void Update()
    {
        if (playAnimation)
        {
            playAnimation = false;
            PlayAnimation(animationData);
        }
    }
}
