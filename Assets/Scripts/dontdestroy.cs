using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroy : MonoBehaviour {

    public static dontdestroy instance;

    private void Awake()
    {
        MakeSingelton();
    }
    
    public void MakeSingelton()
    {
        if(instance!=null)
        {
            Destroy(gameObject);        
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
