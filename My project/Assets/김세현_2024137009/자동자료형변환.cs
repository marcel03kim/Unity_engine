using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 자동자료형변환 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int intNumber = 3827384;

        long intToLong = intNumber;
        Debug.Log(intToLong);

        double intToDouble = intNumber;
        Debug.Log(intToDouble);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
