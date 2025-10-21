using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sam Robichaud NSCC

public class lampLighter : MonoBehaviour
{
    public GameObject trigLight1;
    public GameObject trigLight2;
    public GameObject trigLight3;
    public GameObject trigLight4;

    //void OnTriggerEnter(Collider other)
    //{
    //    trigLight1.SetActive(false);
    //    trigLight2.SetActive(true);
    //    trigLight3.SetActive(false);
    //    trigLight4.SetActive(true);
    //}

    void OnTriggerStay(Collider other)
    {
        trigLight1.SetActive(true);
        trigLight2.SetActive(false);
        trigLight3.SetActive(true);
        trigLight4.SetActive(false);
        trigLight1.SetActive(false);
        trigLight2.SetActive(true);
        trigLight3.SetActive(false);
        trigLight4.SetActive(true);
    }
}
