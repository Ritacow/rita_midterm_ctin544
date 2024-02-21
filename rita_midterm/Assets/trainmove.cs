using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainmove : MonoBehaviour
{

    public bool stop;

    // Start is called before the first frame update
    void Start()
    {
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false)
        {
            transform.Translate(0, 0, 20f * Time.deltaTime);

        }
        // Moves an object to the set position
        else
        {
            Debug.Log("The train has stoped");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        stop = true;
    }

}
