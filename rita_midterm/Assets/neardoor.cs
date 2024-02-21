using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neardoor : MonoBehaviour
{
    private Transform riseKeyPos;
    public bool canRise;
    public bool canPlayAudio;
    public bool havePlayedAudio;
    public bool stillRise;

    public AudioSource nearDoorAudio;

    public float timeRemaining = 2;
    
   
    // Start is called before the first frame update
    void Start()
    {
        riseKeyPos = GameObject.Find("riseKey").transform;
        nearDoorAudio = GameObject.Find("DoorAudio").GetComponent<AudioSource>();
        canRise = false;
        stillRise = false;
        canPlayAudio = false;
        havePlayedAudio = false;
       

    }

    // Update is called once per frame
    void Update()
    {
        if (canRise==true && stillRise ==true)
        {
            Debug.Log("The object will rise");
            
            riseKeyPos.Translate(Vector3.up * Time.deltaTime, Space.World);

            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                
            }

            else
            {
                stillRise = false;
            }


        }







        if (canPlayAudio== true && havePlayedAudio == false)
        {

            nearDoorAudio.Play();
            Debug.Log("Play the Near Door Audio");
            havePlayedAudio = true;
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You come near the door");
        canRise = true;
        stillRise = true;
        canPlayAudio = true;
       


    }
}
