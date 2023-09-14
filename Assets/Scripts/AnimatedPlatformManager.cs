using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedPlatformManager : MonoBehaviour
{
    public void ShapeBeatStart(string tag)
    {
        foreach (var platformAnimated in GetComponentsInChildren<PlatformAnimatedBehaviour>())
        {
            platformAnimated.ScaleWithBeat();
        }
    }
}
