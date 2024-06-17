using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 기본자료형변환 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log((52).ToString());
        Debug.Log((39.401).ToString());
        Debug.Log(('a').ToString());
        Debug.Log((true).ToString());
        Debug.Log((false).ToString());

        Debug.Log((52).ToString().GetType());
        Debug.Log((39.401).ToString().GetType());
        Debug.Log(('a').ToString().GetType());
        Debug.Log((true).ToString().GetType());
        Debug.Log((false).ToString().GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
