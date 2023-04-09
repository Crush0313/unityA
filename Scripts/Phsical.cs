using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phsical : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.velocity = Vector3.left;
        rigid.AddForce(Vector3.up*0.5f, ForceMode.Impulse);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube (1)")
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);

        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 3, ForceMode.Impulse);

        }   
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec * 0.1f, ForceMode.Impulse);
        Debug.Log(rigid.velocity);
        rigid.AddTorque(Vector3.up);

    }
    public void Jump()
    {

        rigid.AddForce(Vector3.up * 3, ForceMode.Impulse);
    }
}
