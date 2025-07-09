using UnityEngine;

public class ColliderAnimationEvent : MonoBehaviour
{
    [SerializeField] private AnimationController animationController;
    [SerializeField] private int id; // This id must match the id of the CustomAnimationEvent that is in the AnimationData.

    private void CheckId(int id)
    {
        if (this.id != id)
            return;

        Debug.Log("fire event");
    }

    private void OnEnable()
    {
        animationController.OnExposeEventId += CheckId;
    }
    
    private void OnDisable()
    {
        animationController.OnExposeEventId -= CheckId;
    }
}
