using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float timeOn = 0.5f;
    public float timeOff = 0.1f;
    private float changeTime = 0f;

    void Update() {
        if (Time.time > changeTime) {
            timeOff = Random.Range(0.1f, 0.4f);
            timeOn = Random.Range(1f, 5f);
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
            if (GetComponent<Light>().enabled) {
                changeTime = Time.time + timeOn;
            } else {
                changeTime = Time.time + timeOff;
            }
        }
}

}
