using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioplay : MonoBehaviour
{

    public AudioClip[] a;
    public AudioSource audioSource;
    private int currentIdx = 0;



    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
       


    }


    private void OnMouseDown()
    {
        
        audioSource.loop = true;
        audioSource.clip = a[currentIdx];
        audioSource.Play();


    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.A))
        {
            
        }
    }
}
