using UnityEngine;

public class DisableObjectEvent : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private GameObject targetCollider;

    private AnimationEventContoller animationEventContoller;

    private void DisableCollider(int id)
    {
        if (this.id != id)
            return;

        targetCollider.SetActive(false);
    }

    private void Awake()
    {
        animationEventContoller = GetComponent<AnimationEventContoller>();
    }

    private void OnEnable()
    {
        animationEventContoller.OnEventTriggerd += DisableCollider;
    }
    
    private void OnDisable()
    {
        animationEventContoller.OnEventTriggerd -= DisableCollider;
    }
}