using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 아웃풋 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int output = 0;
        output += 10;
        output += 205;
        output += 149;
        output /= 2;

        Debug.Log(output);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
