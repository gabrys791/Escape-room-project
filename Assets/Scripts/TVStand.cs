using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVStand : MonoBehaviour
{
    private int tvCabinetCount = 2;
    private bool[] cabinetStates;
    public Animator anim;
    void Start()
    {
        cabinetStates = new bool[tvCabinetCount];
        for (int i = 0; i < tvCabinetCount; i++)
        {
            cabinetStates[i] = false;
        }
    }
    public void ToggleTVCabinet(int index)
    {
        cabinetStates[index] = !cabinetStates[index];
        string paramName = "isOpen_Obj1_" + (index + 1);
        anim.SetBool(paramName, cabinetStates[index]);
    }
}
