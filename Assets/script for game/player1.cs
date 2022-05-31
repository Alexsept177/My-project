using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    [SerializeField]
    //spelare
    Vector3 v3;

    [SerializeField]
    KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative;

    //keybinds för positiv och negativ sida

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //positiv sida
         if (Input.GetKey(keyPositive)) 
            GetComponent<Rigidbody>().velocity += v3;
        //negativ sida 
        if (Input.GetKey(keyNegative)) 
            GetComponent<Rigidbody>().velocity -= v3;
    }
}
