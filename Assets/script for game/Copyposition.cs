using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copyposition : MonoBehaviour
{


    [SerializeField]
    Transform transTarget;

    // Update is called once per frame
    void Update()
    {
        // bolen position
        transform.position = transTarget.position;  
    }
}
