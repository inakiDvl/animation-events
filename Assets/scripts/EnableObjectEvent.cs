using UnityEngine;

public class EnableObjectEvent : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private GameObject targetCollider;

    private AnimationEventContoller animationEventContoller;

    private void EnableCollider(int id)
    {
        if (this.id != id)
            return;

        targetCollider.SetActive(true);
    }

    private void Awake()
    {
        animationEventContoller = GetComponent<AnimationEventContoller>();
    }

    private void OnEnable()
    {
        animationEventContoller.OnEventTriggerd += EnableCollider;
    }

    private void OnDisable()
    {
        animationEventContoller.OnEventTriggerd -= EnableCollider;
    }
}
