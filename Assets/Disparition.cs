using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparition : MonoBehaviour
{

    Rigidbody lobjet;
    public float numberOfCollisions;

    // Start is called before the first frame update
    void Start()
    {
        lobjet = GetComponent<Rigidbody>();
        numberOfCollisions = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere") && numberOfCollisions < 5)
        {
            Debug.Log(numberOfCollisions);
            numberOfCollisions++;
        } 
        else if(collision.gameObject.CompareTag("Sphere") && numberOfCollisions >= 5)
        {
            //this.transform.localScale = new Vector3(0,0,0);
            Destroy(gameObject);
        }
    }
}
