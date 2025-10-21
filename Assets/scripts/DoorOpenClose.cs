using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenClose : MonoBehaviour
{
    public GameObject AnimatedObject;
    [SerializeField] Animator myDoor = null;
    private Animator _animator;

    private void Start()
    {
        _animator = AnimatedObject.GetComponent<Animator>();
    }

    void OnTriggerStay(Collider other)
    {
        myDoor.Play("doorOpen", 0, 0.0f); //calls tro play open animation when trigger is interacted with
        gameObject.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        myDoor.Play("doorClose", 0, 0.0f); //calls to play animation when trigger is interacted with
        gameObject.SetActive(false);
    }


}




























