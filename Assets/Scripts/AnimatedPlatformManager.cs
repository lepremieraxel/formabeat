using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedPlatformManager : MonoBehaviour
{
    public void ShapeBeatStart()
    {
        foreach (var platformAnimated  in GetComponentsInChildren<PlatformAnimatedBehaviour>())
        {
            if (platformAnimated.tag == "PlatformAnimated")
            {
                platformAnimated.ScaleWithBeat();
            }
            if (platformAnimated.tag == "PlatformAnimated2")
            {
                platformAnimated.ScaleWithBeat2();
            }
        }
    }
}
