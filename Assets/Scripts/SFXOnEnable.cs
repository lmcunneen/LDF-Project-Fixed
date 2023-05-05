using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXOnEnable : MonoBehaviour
{
    [SerializeField]
    private AudioClip soundToPlay;
    public bool remoteSoundEffect; //Check this in Inspector if you want this played elsewhere
    public GameObject remoteSFXLocation;
    private Vector3 remoteObjectLoc;
    public AudioSource sourceToPlay; // THIS NEEDS TO BE AN AUDIOSOURCE COMPONENT IN YOUR LEVEL! Maybe 'SFXSytem'
    public float volume;

    public float intervalSeconds;
    public float durationSeconds;

    private void Start()
    {
        if (sourceToPlay == null)
        {
            sourceToPlay = GameObject.Find("SFXSystem").GetComponent<AudioSource>();
        }

        if (remoteSFXLocation == null)
        {
            remoteSoundEffect = false;
        }
        else
        {
            remoteObjectLoc = remoteSFXLocation.transform.position;
        }

        StartCoroutine(SFXRoutine());
    }

    private IEnumerator SFXRoutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(intervalSeconds);
            AudioSource.PlayClipAtPoint(soundToPlay, remoteObjectLoc);
            yield return new WaitForSeconds(durationSeconds);
        }
    }

    public void PlaySoundClip()
    {
        sourceToPlay.PlayOneShot(soundToPlay, volume); //THIS PLAYS IT AT THE PLAYER LOCATION
    }

}