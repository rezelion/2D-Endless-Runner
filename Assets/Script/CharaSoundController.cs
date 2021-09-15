using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaSoundController : MonoBehaviour
{
    private AudioSource audioPlayer;
    public AudioClip jump;
    public AudioClip scoreHighlight;
    public AudioClip fallScream;

    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }
    public void PlayJump() {
        audioPlayer.PlayOneShot(jump);
    }
    public void PlayFalling()
    {
        audioPlayer.PlayOneShot(fallScream);
    }
    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
