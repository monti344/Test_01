using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorPanel : MonoBehaviour
{
    private const string _triggerButton = "Click";

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void ShowCreator()
    {
        _animator.SetTrigger(_triggerButton);
    }
}
