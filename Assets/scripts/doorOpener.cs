using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class doorOpener : MonoBehaviour
{
    public GameObject AnimatedObject;
    private Animator _animator;

    private void Start()
    {
        _animator = AnimatedObject.GetComponent<Animator>();
        _animator.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        _animator.enabled = true;
    }

    void OnTriggerExit(Collider other)
    {


        _animator.enabled = false;
    }


}