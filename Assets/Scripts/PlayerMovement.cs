using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Transform orientation;
    private Rigidbody rb;
    //public Drawer drawer;
    public Camera playerCamera;
    public LayerMask interactableLayer;
    public float interactionDistance;
    private Drawer currentDrawer;
    private Closet currentCloset;
    public KitchenCloset KitchenCloset;
    public TVStand TVStand;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 moveDircetion = orientation.forward * vertical + orientation.right * horizontal;
        rb.velocity = moveDircetion * speed;
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        RaycastHit hit;
        currentDrawer = null;
        currentCloset = null;
        if (Physics.Raycast(ray, out hit, interactionDistance, interactableLayer))
        {
            Drawer drawer = hit.collider.GetComponent<Drawer>();
            //Debug.Log(drawer.name);
            if (drawer != null)
            {
                currentDrawer = drawer;
                //Debug.Log(currentDrawer.name);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log(currentDrawer);
                    currentDrawer.ToggleDrawer();
                }
                return;
            }
            Closet closet = hit.collider.GetComponent<Closet>();
            if (closet != null)
            {
                currentCloset = closet;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    currentCloset.ToggleCloset();
                }
                return;
            }
            string closetName = hit.collider.name;
            int closetIndex;
            if (int.TryParse(closetName.Replace("door0", ""), out closetIndex))
            {
                if (Input.GetKey(KeyCode.E))
                {
                    KitchenCloset.ToggleCabinet(closetIndex - 1);
                }

            }
            if (closetName.StartsWith("grp"))
            {
                string tvCabinetName = closetName;
                int tvCabinetIndex;
                if (int.TryParse(tvCabinetName.Replace("grp_doors", ""), out tvCabinetIndex))
                {
                    if (Input.GetKey(KeyCode.E))
                    {
                        Debug.Log(tvCabinetIndex);
                        TVStand.ToggleTVCabinet(tvCabinetIndex - 1);
                    }
                }
            }
        }

    }
}
