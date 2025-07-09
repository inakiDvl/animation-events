using System;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Temporal fields for playing an animation.
    public AnimationData animationData; 
    public bool playAnimation = false;

    public event Action<int> OnExposeEventId;

    public void PlayAnimation(AnimationData animation)
    {
        // Here we should tell the animator to play the animation.

        ExposeEventsIds(animation);
    }

    private void ExposeEventsIds(AnimationData animation)
    {
        foreach (var animationEvent in animation.AnimationEvents)
        {
            OnExposeEventId?.Invoke(animationEvent.Id);
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
