using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateObjects : MonoBehaviour
{

    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            Instantiate(sphere, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }





}
