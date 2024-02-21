using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcome : MonoBehaviour
{

    public GameObject welcometext;
    public GameObject player;


    void Start()
    {

        welcometext.SetActive(false);

    }




    public void OnTriggerEnter(Collider player)
    {
        Debug.Log("You Enter the zone");
        welcometext.SetActive(true);
    }
}
