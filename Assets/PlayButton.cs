using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public AudioSource audioSource; // reference audio source
    public Button playPauseButton; // reference play/pause button
    private bool isPlaying = false; // flag for keeping track of whether music is playing
    
    // Start is called before the first frame update
    void Start()
    {
        playPauseButton.onClick.AddListener(delegate{TogglePlayPause();}); 
        Debug.Log("Script Initialized Successfully"); // cfm script loaded
    }

    public void TogglePlayPause()
    {
        if (isPlaying) 
        {
            audioSource.Pause(); // pause audio
            isPlaying = false;   // invert flag
            playPauseButton.GetComponentInChildren<Text>().text = "Play"; // show "play"
            Debug.Log("Audio Paused"); // for debugging
        } 
        else 
        {
            audioSource.Play(); // play audio
            isPlaying = true;   // invert flag
            playPauseButton.GetComponentInChildren<Text>().text = "Pause"; // show "pause"
            Debug.Log("Audio Playing"); // for debugging
        }
    }
}
