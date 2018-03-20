using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppScreen : MonoBehaviour {

    public Animation anim;

    private void Awake()
    {
        anim = GetComponent<Animation>();    
    }

    public virtual void OnEnabledScreen() { }    
}
