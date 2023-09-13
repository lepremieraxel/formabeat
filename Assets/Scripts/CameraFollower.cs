using Cinemachine;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Vector3[] waypoints; 
    void Start()
    {
        transform.DOPath(waypoints,10,pathType:PathType.Linear,gizmoColor:Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
