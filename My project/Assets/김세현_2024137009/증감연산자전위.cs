using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 증감연산자전위 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 10;
        Debug.Log(number);
        Debug.Log(--number);
        Debug.Log(++number);
        Debug.Log(--number);
        Debug.Log(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
