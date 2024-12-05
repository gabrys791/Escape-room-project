using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenCloset : MonoBehaviour
{

    public Animator animator;

    private int cabinetCount = 5;
    private bool[] cabinetStates;
    void Start()
    {
        cabinetStates = new bool[cabinetCount];
        for (int i = 0; i < cabinetCount; i++)
        {
            cabinetStates[i] = false;
        }
    }

    public void ToggleCabinet(int index)
    {
        if (index < 0 || index >= cabinetCount)
        {
            Debug.LogError("Invalid cabinet index!");
            return;
        }


        cabinetStates[index] = !cabinetStates[index];

        string paramName = "isOpen_Obj_" + (index + 1);
        animator.SetBool(paramName, cabinetStates[index]);

        Debug.Log($"Toggled {paramName} to {cabinetStates[index]}");
    }
}
