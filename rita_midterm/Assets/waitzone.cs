using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitzone : MonoBehaviour
{
    public GameObject t1;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider player)
    {

 
        Debug.Log("The train is moving");
        t1.transform.Translate(0, 0, 50f * Time.deltaTime);
        


    }
}
