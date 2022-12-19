using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class ActivateShake : MonoBehaviour
{
    [SerializeField] public float mag;
    [SerializeField] public float rough;
    [SerializeField] public float fadein;
    [SerializeField] public float fadeout;
    // Update is called once per frame
    void Update()
    {
        CameraShaker.Instance.ShakeOnce(mag, rough, fadein, fadeout);
    }
}
