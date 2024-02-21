using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalAppear : MonoBehaviour
{

    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {
        portal = GameObject.Find("particlePortal");
        portal.SetActive(false);
    }

    // Update is called once per frame
 
    void OnTriggerEnter(Collider other)
    {
        portal.SetActive(true);
    }
}
