using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatmove : MonoBehaviour
{
    public GameObject destination;

    public float speed;
    public Vector3 newPosition;
    public object boat;
    public int movementSpeed;
    public int horizontalInput;
    public int verticalInput;

    bool isCoroutineStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2.0f;
        newPosition = destination.transform.position;
        movementSpeed = 1;
        horizontalInput = 0;
        verticalInput = 1;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space") && (!isCoroutineStarted))
        {

            Debug.Log("The boat begin to move");
            StartCoroutine(MoveFunction());
        }


    }


    IEnumerator MoveFunction()
    {
        isCoroutineStarted = true;
        float timeSinceStarted = 0f;
        while (true)
        {
  
            timeSinceStarted += Time.deltaTime;
            //boat.transform.position = Vector3.Lerp(boat.transform.position, newPosition, timeSinceStarted);
            transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

            // If the object has arrived, stop the coroutine
            if (transform.position == newPosition)
            {
                yield break;
            }

            // Otherwise, continue next frame
            yield return null;
        }
    }
}
