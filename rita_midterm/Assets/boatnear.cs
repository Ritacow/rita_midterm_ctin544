using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatnear : MonoBehaviour
{

    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;
    public float timeRemaining = 7;
    public float timeRemaining_two = 17;
    public bool timestart;
    // Start is called before the first frame update
    void Start()
    {
        hint1.SetActive(false);
        hint2.SetActive(false);
        hint3.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0 && timestart ==true)
        {
            timeRemaining -= Time.deltaTime;


            if (timeRemaining <= 0)
            {
                hint2.SetActive(true);
            }
            
            
        }

        if (timeRemaining_two >0 && timestart == true)
        {
            timeRemaining_two -= Time.deltaTime;
            if (timeRemaining_two <= 0)
            {
                hint3.SetActive(true);
            }
             
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        timestart = true;
        hint1.SetActive(true);

        //hint2.SetActive(true);
    }
}
