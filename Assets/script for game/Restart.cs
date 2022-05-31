using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    [SerializeField]
    KeyCode keyRestart;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //lava mark om bolen 
        if(Input.GetKey(keyRestart))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
