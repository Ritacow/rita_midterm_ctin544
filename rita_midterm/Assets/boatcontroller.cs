using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatcontroller : MonoBehaviour

{

    // Adjust the speed for the application.
    public float speed = 1.0f;

    // The target (cylinder) position.
    private Transform target;

    public Renderer m_ObjectRenderer;
    void Awake()
    {

        // Position the cube at the origin.
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        // Create and position the cylinder. Reduce the size.
        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        //Camera.main.transform.position = new Vector3(0.85f, 1.0f, -3.0f);
        //cylinder.GetComponent<Renderer>().material.color.a = 1.0f;
        //
        m_ObjectRenderer = cylinder.GetComponent<Renderer>();
        //Change the GameObject's Material Color to red
        //m_ObjectRenderer.material.color = Color.red;
        //m_ObjectRenderer.SetActive(false);
        m_ObjectRenderer.enabled = false;





        // Grab cylinder values and place on the target.
        target = cylinder.transform;
        target.transform.localScale = new Vector3(0.15f, 1.0f, 0.15f);
        target.transform.position = new Vector3(0.8f, 0.0f, 0.8f);

        // Position the camera.
       //Camera.main.transform.position = new Vector3(0.85f, 1.0f, -3.0f);
        //Camera.main.transform.localEulerAngles = new Vector3(15.0f, -20.0f, -0.5f);

        // Create and position the floor.
        //GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
        //floor.transform.position = new Vector3(0.0f, -1.0f, 0.0f);
    }

    void Update()
    {
        // Move our position a step closer to the target.
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        // Check if the position of the cube and sphere are approximately equal.
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            // Swap the position of the cylinder.
            target.position *= -1.0f;
        }
    }
}
