using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    void Example()
    {
        // Physics.gravity för bolen
        Physics.gravity = new Vector3(0, -1.5F, 0);
    }
}