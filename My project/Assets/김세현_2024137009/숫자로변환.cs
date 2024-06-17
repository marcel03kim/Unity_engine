using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 숫자로변환 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(int.Parse("52")); 
        Debug.Log(long.Parse("423"));
        Debug.Log(float.Parse("59.283"));
        Debug.Log(double.Parse("46.2911"));

        Debug.Log(int.Parse("52").GetType());
        Debug.Log(long.Parse("423").GetType());
        Debug.Log(float.Parse("59.283").GetType());
        Debug.Log(double.Parse("46.2911").GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
