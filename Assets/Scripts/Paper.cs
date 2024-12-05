using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Paper : MonoBehaviour
{
    [SerializeField] private GameObject noteCanvas;
    [SerializeField] private TMP_Text noteTextAreaUI;
    [SerializeField][TextArea] private string text;
    [SerializeField] private UnityEvent openEvent;
    [SerializeField] private PlayerMovement playerMovement;
    private bool isOpen = false;
    public void ShowNote()
    {
        noteTextAreaUI.text = text;
        noteCanvas.SetActive(true);
        //openEvent.Invoke();
        DisablePlayer(true);
        isOpen = true;
    }
    private void DisableNote()
    {
        noteCanvas.SetActive(false);
        DisablePlayer(false);
        isOpen = false;
    }
    private void DisablePlayer(bool disable)
    {
        playerMovement.enabled = !disable;
    }
    private void Update()
    {
        if (isOpen)
        {
            if(Input.GetKey(KeyCode.Q))
            {
                DisableNote();
            }
        }
    }
}
