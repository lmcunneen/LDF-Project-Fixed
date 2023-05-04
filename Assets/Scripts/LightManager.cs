using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public float intervalSeconds;
    public float durationSeconds;
    public GameObject objectToActivate;

    private void Start()
    {
        StartCoroutine(ActivationRoutine());
    }

    private IEnumerator ActivationRoutine()
    {
        while(true)
        {
            //Turn light that is set to false(off) to True(on).
            objectToActivate.SetActive(false);

            //Wait for x amount of secs.
            yield return new WaitForSeconds(intervalSeconds);

            //Game object will turn off
            objectToActivate.SetActive(true);

            //Turn the Game Oject back off after x amount of secs.
            yield return new WaitForSeconds(durationSeconds);
        }
    }
}