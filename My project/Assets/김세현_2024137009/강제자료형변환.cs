using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 강제자료형변환 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        long longNumber = 37529375L + 48172L;
        int intNumber = (int)longNumber;
        Debug.Log(intNumber);

        long longNumber2 = 4323;
        int intNumber2 = (int)longNumber2;
        Debug.Log(intNumber2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
