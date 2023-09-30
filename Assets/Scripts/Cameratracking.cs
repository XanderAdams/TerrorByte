using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameratracking : MonoBehaviour
{

    public Transform target;
    public Vector3 cameraOffset;
    Vector3 velocity = Vector3.zero;
    public float speed;
    public float xMin;
    public float yMin;
    public float xMax;
    public float yMax;

    private void FixedUpdate()
    {
        float xClamp = Mathf.Clamp(target.position.x, xMin, xMax);
        float yClamp = Mathf.Clamp(target.position.y, yMin, yMax);

        Vector3 targetpos = target.position + cameraOffset;
        Vector3 clampedpos = new Vector3(Mathf.Clamp(targetpos.x, xMin, xMax), Mathf.Clamp(targetpos.y, yMin, yMax),targetpos.z-1);
        Vector3 smoothpos = Vector3.SmoothDamp(transform.position, clampedpos, ref velocity, speed * Time.deltaTime);
  
        transform.position = smoothpos;
    }
}
