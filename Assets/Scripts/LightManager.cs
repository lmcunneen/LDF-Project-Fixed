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
            objectToActivate.SetActive(false);
            yield return new WaitForSeconds(intervalSeconds);
            objectToActivate.SetActive(true);
            yield return new WaitForSeconds(durationSeconds);
        }
    }
}