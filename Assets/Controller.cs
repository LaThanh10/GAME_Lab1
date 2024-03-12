using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(message:"Press A");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(message:"Press D");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log(message:"Get Key D");
        }

    }
}
