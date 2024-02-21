using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatenter : MonoBehaviour
{
    public GameObject boat;
    




    // Start is called before the first frame update
    void Start()
    {
       boat = GameObject.Find("boat");
       
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void OnTriggerEnter(Collider other)
    {
        boat.SetActive(false);
    }
}
