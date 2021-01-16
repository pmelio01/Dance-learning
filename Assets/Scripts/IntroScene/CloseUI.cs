using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("isPressed", true);
        Debug.Log("Animation status: "+ anim);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Here");
    }
}
