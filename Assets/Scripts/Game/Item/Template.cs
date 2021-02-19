using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Template : MonoBehaviour
{
    [SerializeField] private float _offsetX;

    public float OffsetX => _offsetX;
}
