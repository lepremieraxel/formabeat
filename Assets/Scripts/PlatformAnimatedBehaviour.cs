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

    public void ScaleWithBeat2()
    {
        Sequence mySeq1 = DOTween.Sequence();
        mySeq1.SetLoops(-1);
        mySeq1.Append(transform.DOScaleY(15, 0.10f));
        mySeq1.Append(transform.DOScaleY(3, 0.38f));
    }
}
