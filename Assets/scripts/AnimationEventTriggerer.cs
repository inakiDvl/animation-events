using UnityEngine;

public abstract class AnimationEventTriggerer : MonoBehaviour
{
    public abstract int GetId();
    public abstract void TriggerEvent();
}
