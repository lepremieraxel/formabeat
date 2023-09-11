using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    void Start()
    {
        Sequence camera = DOTween.Sequence();
        camera.AppendInterval(3);
        camera.Append(transform.DOMoveY(29, 10));
        camera.Append(transform.DOMoveX(-120, 20));
    }
}
