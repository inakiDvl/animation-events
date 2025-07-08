using UnityEngine;

public class ColliderAnimationEvent : MonoBehaviour, IAnimationEventTriggerer
{
    [SerializeField] private int id;

    private AnimationController animationController;

    public int GetId()
    {
        throw new System.NotImplementedException();
    }

    public void TriggerEvent()
    {
        throw new System.NotImplementedException();
    }

    private void Awake()
    {
        animationController = GetComponent<AnimationController>();
    }
}

public interface IAnimationEventTriggerer
{
    public int GetId();
    public void TriggerEvent();
}
