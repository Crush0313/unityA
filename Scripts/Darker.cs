using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darker : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {

            mat.color = new Color(32, 42, 61);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
