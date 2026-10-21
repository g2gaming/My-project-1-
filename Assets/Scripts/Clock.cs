using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    [SerializeField]
    private Transform hoursPivot, minutesPivot, secondsPivot;

    void Update() {
        Debug.Log(DateTime.Now.Hour);
        Debug.Log(DateTime.Now.Minute);
        Debug.Log(DateTime.Now.Second);
        hoursPivot.localRotation = Quaternion.Euler(0, 0, -30 * DateTime.Now.Hour);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, -6 * DateTime.Now.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, -6 * DateTime.Now.Second);

    }


}
