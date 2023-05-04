using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlacksmithLight : MonoBehaviour
{
    public float intervalSeconds;
    public float activeLength;

    private BoxCollider boxCollider;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
        StartCoroutine(LightSystem());
    }

    private IEnumerator LightSystem()
    {
        while(true)
        {
            //Turn My game object that is set to false(off) to True(on).
            boxCollider.enabled = false;

            //Wait for x amount of secs.
            yield return new WaitForSeconds(intervalSeconds);

            //Game object will turn off
            boxCollider.enabled = true;

            //Turn the Game Oject back off after x amount of secs.
            yield return new WaitForSeconds(activeLength);
        }
    }
}
