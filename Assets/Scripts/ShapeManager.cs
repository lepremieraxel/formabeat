using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    public void ShapeBeatStart(string tag)
    {
        foreach (var shape in GetComponentsInChildren<ShapeBehaviour>())
        {
            shape.ScaleWithBeat();
        }
    }
}
