using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whisperatdoor : MonoBehaviour
{
    // Start is called before the first frame update

    public bool hasplayed;
    public bool startplay;
    public AudioSource whisperatDoor;
    void Start()
    {
        whisperatDoor = GameObject.Find("DoorWhisper").GetComponent<AudioSource>();
        hasplayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(startplay == true && hasplayed == false){
            whisperatDoor.Play();
            hasplayed = true;
        }
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        startplay = true;
    }





}
