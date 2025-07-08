using System;
using UnityEngine;

[Serializable]
public class CustomAnimationEvent
{
    public enum EventMode // Describes how the event must be treated.
    {
        Start, // The event begins.
        Stpo // The event ends.
    }
    // Id is used to link the event with the code or action that must be triggered.
    [field: SerializeField] public int Id { get; private set; }
    [field: SerializeField] public EventMode Mode { get; private set; }
    [field: SerializeField] public int Frame { get; private set; } // When it musst be triggered.
}
