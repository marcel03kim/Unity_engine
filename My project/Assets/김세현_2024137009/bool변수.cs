using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bool변수 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool one = 100 < 0;
        bool other = -50 > 0;

        Debug.Log(one);
        Debug.Log(other);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
