using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTracker : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private float _OffsetX;

    private void Update()
    {
        transform.position = new Vector3(_ball.transform.position.x - _OffsetX, transform.position.y, transform.position.z);
    }
}
