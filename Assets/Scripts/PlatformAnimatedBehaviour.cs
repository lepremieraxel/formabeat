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

    public void MoveWithBeat()
    {
        Sequence mySeq2 = DOTween.Sequence();
        mySeq2.SetLoops(-1);
        mySeq2.Append(transform.DOLocalMoveY(185f, 0.48f));
        mySeq2.Append(transform.DOLocalMoveY(169.51f, 0.48f));
    }

    public void MoveWithBeat2()
    {
        Sequence mySeq3 = DOTween.Sequence();
        mySeq3.SetLoops(-1);
        mySeq3.Append(transform.DOLocalMoveY(186f, 0.48f));
        mySeq3.Append(transform.DOLocalMoveY(202f, 0.48f));
    }
}
