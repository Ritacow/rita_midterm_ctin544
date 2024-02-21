using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlepickup : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera boatCamera;

    // Start is called before the first frame update

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowboatView()
    {
        firstPersonCamera.enabled = false;
        boatCamera.enabled = true;
    }

    public void ShowFirstPersonView()
    {
        firstPersonCamera.enabled = true;
        boatCamera.enabled = false;
    }

    private void OnMouseDown()
    {
        ShowboatView();  
    }


    private void Start()
    {
        boatCamera.enabled = false;
        firstPersonCamera.enabled = true;
    }

    //for raycasting


    void FixedUpdate()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }



}
