using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchtoending : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SwitchScene()
    {
        Debug.Log("Scene is loading");
        SceneManager.LoadScene("scene_end", LoadSceneMode.Additive);
    }
    private void OnTriggerEnter(Collider player_collision)
    {


        if (player_collision.CompareTag("Player"))
        {
            Debug.Log("You collide");
            SwitchScene();
        }
    }
}
