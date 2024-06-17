using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 숫자와문자열덧셈 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(52 + 273);
        Debug.Log("52" + 273);
        Debug.Log(52 + "273");
        Debug.Log("52" + "273");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
