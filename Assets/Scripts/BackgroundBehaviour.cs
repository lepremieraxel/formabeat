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
        mySeq.Append(SR.DOColor(new Color(0.390566f, 0.5124528f, 1f, 1f), 0.48f).SetEase(Ease.OutExpo));
        mySeq.Append(SR.DOColor(new Color(1f, 0.37f, 1f, 1f), 0.48f).SetEase(Ease.OutExpo));
        mySeq.Append(SR.DOColor(new Color(0.67f, 0.27f, 1f, 1f), 0.48f).SetEase(Ease.OutExpo));
    }
}
