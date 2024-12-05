using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : MonoBehaviour
{
    public Transform closet;
    private bool isOpen = false;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isOpen_Obj_1", isOpen);
    }
    public void ToggleCloset()
    {
        isOpen = !isOpen;    
    }
}
