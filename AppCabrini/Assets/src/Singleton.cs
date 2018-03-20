using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton
{
    private static Singleton _instance;
    public static Singleton instance { get { return Instance(); } }


    private static Singleton Instance()
    {
        if (_instance == null)
            _instance = new Singleton();
        
        return _instance;
    }


    private Singleton() {}
}
