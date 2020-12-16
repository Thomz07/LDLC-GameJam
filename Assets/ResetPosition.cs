using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    [SerializeField]
    Vector3 positionDeDepart;
    // Start is called before the first frame update
    void Start()
    {
        positionDeDepart = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -1f)
        {
            transform.position = positionDeDepart;
        }
    }
}
