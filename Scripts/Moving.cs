using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    Vector3 target = new Vector3(8, 0.5f, 0);
    void Update()
    {
        //    Vector3 vec = new Vector3(Input.GetAxis("Horizontal")*0.1f, Input.GetAxis("Vertical")*0.1f, 0);
        //    transform.Translate(vec*Time.deltaTime);
        //transform.position = Vector3.MoveTowards(transform.position, target, 1f);
        Vector3 vec = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref vec, 0.2f*Time.deltaTime);
        //transform.position = Vector3.Lerp(transform.position, target, 0.05f);
        //transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
