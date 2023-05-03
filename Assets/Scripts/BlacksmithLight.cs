using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlacksmithLight : MonoBehaviour
{
    public float intervalTime = 3.0f;

    private void Start()
    {
        StartCoroutine(AnvilLight());
    }

    private IEnumerator AnvilLight()
    {
        for (int i = 0; i < intervalTime; i++)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Hello, world!");
        }
    }
}
