using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Keypad : MonoBehaviour
{
    [SerializeField] private GameObject keypadCanvas;

    public void ShowKeypad()
    {
        if (keypadCanvas != null)
        {
            Cursor.visible = true; // Ensure the cursor is visible
            Cursor.lockState = CursorLockMode.None; // Unlock the cursor
            SceneManager.LoadScene(2);
        }
        else
        {
            Debug.LogError("Keypad Canvas not assigned!");
        }
    }
}
