using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 겟타입활용 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int _int = 100;
        long _long = 2938457;
        float _float = 39.485f;
        double _double = 19.402;
        char _char = '김';
        string _string = "세현";

        Debug.Log(_int.GetType());
        Debug.Log(_float.GetType());
        Debug.Log(_long.GetType());
        Debug.Log(_double.GetType());
        Debug.Log(_char.GetType());
        Debug.Log(_string.GetType());

        Debug.Log(100.GetType());
        Debug.Log(39.485f.GetType());
        Debug.Log(2938457.GetType());
        Debug.Log(19.402.GetType());
        Debug.Log('김'.GetType());
        Debug.Log("세현".GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
