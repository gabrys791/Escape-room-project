using NavKeypad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    [SerializeField] private float length;
    [SerializeField] private Image crossHair;
    private Camera camera;
    private Paper paper;
    private Keypad keypad;
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f)), transform.forward, out hit, length))
        {
            // Detect if looking at a Paper
            var readableItem = hit.collider.GetComponent<Paper>();
            if (readableItem != null)
            {
                paper = readableItem;
                HighlightCrossHair(true);
            }
            else
            {
                ClearNote();
            }

            // Detect if looking at a Keypad
            var keypadItem = hit.collider.GetComponent<Keypad>();
            if (keypadItem != null)
            {
                keypad = keypadItem;
                HighlightCrossHair(true);
            }
        }
        else
        {
            ClearNote();
        }
        if (paper != null && Input.GetKey(KeyCode.E))
        {
            paper.ShowNote();
        }
        if (keypad != null && Input.GetKey(KeyCode.E))
        {
            keypad.ShowKeypad();
        }
    }
    private void ClearNote()
    {
        if (paper != null)
        {
            HighlightCrossHair(false);
            paper = null;
        }
        if(keypad != null)
        {
            HighlightCrossHair(false);
            keypad = null;
        }
    }
    private void HighlightCrossHair(bool on)
    {
        if(on)
        {
            crossHair.color = Color.blue;
        }
        else
        {
            crossHair.color = Color.white;
        }
    }
}
