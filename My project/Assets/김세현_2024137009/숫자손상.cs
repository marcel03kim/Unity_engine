using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 숫자손상 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        long longNumber = 4837293L + 384729L;
        int longToInt = (int)longNumber;
        Debug.Log(longToInt);

        double doubleNumber = 34.2937;
        int doubleToInt = (int)doubleNumber;
        Debug.Log(doubleToInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
