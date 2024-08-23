using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailCircleRun : MonoBehaviour
{
    public float distance = 1;
    public float radiansSpeed = Mathf.PI / 180;
    public float radians;
    private Vector3 posBak;

    void Start()
    {
        posBak = transform.position;
    }

    private void FixedUpdate() {
        radians += radiansSpeed;
        if (radians > Mathf.PI) {
            radians -= Mathf.PI * 2;
        }
        var cos = Mathf.Cos(radians);
        var sin = Mathf.Sin(radians);
        transform.position = new Vector3(
            posBak.x + cos * distance,
            posBak.y + sin * distance,
            posBak.z);
    }
}
