using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    Rigidbody lobjet;

    // Start is called before the first frame update
    void Start()
    {
        lobjet = GetComponent<Rigidbody>();
        lobjet.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Sphere"))
        {
            lobjet.isKinematic = false;
        }
    }
}
