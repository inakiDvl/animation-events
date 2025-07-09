using UnityEngine;

public class ColliderAnimationEvent : AnimationEventTriggerer
{
    // This id must match the id of the CustomAnimationEvent that is in the AnimationData.
    [SerializeField] private int id;

    public override int GetId()
    {
        return id;
    }

    public override void TriggerEvent()
    {
        Debug.Log("Event triggerd.");
    }
}
