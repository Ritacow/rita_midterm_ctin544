using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterdoor : MonoBehaviour
{

    public GameObject flower;
    public GameObject riseObject;
    private bool canFade;
    public bool canRise;
    private Color alphaColor;
    private float timeToFade = 1.0f;
    private Transform objectPos;
    public float speed;

    public Vector3 p;
    // Start is called before the first frame update
    void Start()
    {
        canFade = false;
        alphaColor = flower.GetComponent<MeshRenderer>().material.color;
        alphaColor.a = 0;
        canRise = false;
        speed = 0.1f;

        objectPos = GameObject.Find("riseObject").transform;
        p = objectPos.position;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (canFade)
        {

            Debug.Log("The scene is fading");
            //flower.GetComponent<MeshRenderer>().material.color = Color.Lerp(flower.GetComponent<MeshRenderer>().material.color, alphaColor, timeToFade * Time.deltaTime);
        }
        if (canRise)
        {
            Debug.Log("The object is rising");
            p.z += speed * Time.deltaTime;

           objectPos.Translate(Vector3.up * Time.deltaTime, Space.World);


        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You enter the zone");
        canFade = true;
        canRise = true;
    }


}
