using System;
using System.Collections.Generic;

using UnityEngine;

/// <summary>
/// SpawnableObject is a wrapper for three GameObjects representing an object in the top lane, middle lane, and bottom lane.
/// <c>GetSpawnable()</c> returns a list containing the objects tied to their positions, ignoring nulls (null meaning an empty space)
/// </summary>
public class SpawnableObject : ScriptableObject {

    public Transform Top;
    public Transform Middle;
    public Transform Bottom;

    public Transform Get(ObjectPosition pos) {
        switch (pos) {
        case ObjectPosition.Top:
            return Top;
        case ObjectPosition.Middle:
            return Middle;
        case ObjectPosition.Bottom:
            return Bottom;
        default:
            return null;
        }
    }

    public List<KeyValuePair<Transform, ObjectPosition>> GetSpawnable() {
        var nonNull = new List<KeyValuePair<Transform, ObjectPosition>>();
        if (Top != null)
            nonNull.Add(new KeyValuePair<Transform, ObjectPosition>(Top, ObjectPosition.Top));
        if (Middle != null)
            nonNull.Add(new KeyValuePair<Transform, ObjectPosition>(Middle, ObjectPosition.Middle));
        if (Bottom != null)
            nonNull.Add(new KeyValuePair<Transform, ObjectPosition>(Bottom, ObjectPosition.Bottom));
        return nonNull;
    }
}

public enum ObjectPosition {
    Top, Middle, Bottom
}