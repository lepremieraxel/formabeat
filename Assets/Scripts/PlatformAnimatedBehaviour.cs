using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAnimatedBehaviour : MonoBehaviour
{
    public void ScaleWithBeat()
    {
        Sequence mySeq = DOTween.Sequence();
        mySeq.SetLoops(-1);
        mySeq.Append(transform.DOScaleX(8, 0.10f));
        mySeq.Append(transform.DOScaleX(4, 0.38f));
    }
}
