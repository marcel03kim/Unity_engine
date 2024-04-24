using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 소숫점제거 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        double number = 52.2536;
        Debug.Log(number.ToString("0.0"));
        Debug.Log(number.ToString("0.00"));
        Debug.Log(number.ToString("0.000"));
        Debug.Log(number.ToString("0.0000"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
