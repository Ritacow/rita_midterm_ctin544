using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchtoending : MonoBehaviour
{
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
