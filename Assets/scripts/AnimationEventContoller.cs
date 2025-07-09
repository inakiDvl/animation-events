using System;
using UnityEngine;

public class AnimationEventContoller : MonoBehaviour
{
    public event Action<int> OnEventTriggerd;

    public void TriggerEvent(int id)
    {
        OnEventTriggerd?.Invoke(id);
    }
}
