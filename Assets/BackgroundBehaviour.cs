using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BackgroundBehaviour : MonoBehaviour
{
    public SpriteRenderer SR;
    public void ColorWithBeat()
    {
        Sequence mySeq = DOTween.Sequence();
        mySeq.SetLoops(-1);
        mySeq.Append(SR.DOColor(Color.blue, 0.48f));
        mySeq.Append(SR.DOColor(Color.green, 0.48f));
        mySeq.Append(SR.DOColor(Color.magenta, 0.48f));
        mySeq.Append(SR.DOColor(Color.yellow, 0.48f));
    }
}
