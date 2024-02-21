using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearMusicNotes : MonoBehaviour
{

    public AudioSource noteAudio;
    public GameObject musicNote;

    public bool canPlay;
    public bool hasPlayed;

    // Start is called before the first frame update
    void Start()
    {
        canPlay = false;
        hasPlayed = false;
        noteAudio = GameObject.Find("NoteOneAudio").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canPlay == true & hasPlayed == false)
        {
            noteAudio.Play();
            hasPlayed = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canPlay = true;
    }
    private void OnTriggerExit(Collider other)
    {
        canPlay = false;
        hasPlayed = false;
    }
}
