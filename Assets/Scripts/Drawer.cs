using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    public Transform drawer;
    public Vector3 openPosition;
    public Vector3 closedPosition;
    public float speed = 2.0f;

    private bool isOpen = false;
    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = closedPosition;
        drawer.localPosition = closedPosition;
    }

    void Update()
    {
        drawer.localPosition = Vector3.Lerp(drawer.localPosition, targetPosition, Time.deltaTime * speed);
    }

    public void ToggleDrawer()
    {
        isOpen = !isOpen;
        targetPosition = isOpen ? openPosition : closedPosition;
    }
}
