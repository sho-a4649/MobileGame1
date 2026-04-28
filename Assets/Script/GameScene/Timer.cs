using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time {  get; private set; }
    public bool isRunning = true;

    private void Update()
    {
        if (!isRunning) return;
        time += Time.deltaTime;
    }

    public void Stop()
    {
        isRunning = false;
    }
}
