using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBehaviour : MonoBehaviour
{
    public void ScaleWithBeat()
    {
        Sequence mySeq = DOTween.Sequence();
        mySeq.SetLoops(-1);
        mySeq.Append(transform.DOScale(0.15f, 0.10f));
        mySeq.Append(transform.DOScale(0.07f, 0.38f));
    }
}
