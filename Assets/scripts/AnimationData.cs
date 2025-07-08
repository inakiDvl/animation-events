using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new animation", menuName = "Scriptable Objects/animation")]
public class AnimationData : ScriptableObject
{
    [field: SerializeField] public string AnimationName { get; private set; }
    [field: SerializeField] public AnimationClip AnimationClip { get; private set; }
    [field: SerializeField] public List<CustomAnimationEvent> AnimationEvents { get; private set; } = new();

    public int NameHash { get; private set; }

    private void OnValidate()
    {
        NameHash = Animator.StringToHash(AnimationName);
    }
}
