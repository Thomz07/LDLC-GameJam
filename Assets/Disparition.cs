using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Disparition : MonoBehaviour
{
    Rigidbody lobjet;
    public float numberOfCollisions;
    Score scoreObject;

    [SerializeField]
    int scoreDeTouche = 5;
    [SerializeField]
    int scoreDeDestruction = 10;
    [SerializeField]
    int nombreDeHp = 5;

    // Start is called before the first frame update
    void Start()
    {
        lobjet = GetComponent<Rigidbody>();
        numberOfCollisions = 0;
        scoreObject = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere") && numberOfCollisions < nombreDeHp)
        {
            Debug.Log(numberOfCollisions);
            numberOfCollisions++;
            scoreObject.changeScore(scoreDeTouche);
        } 
        else if(collision.gameObject.CompareTag("Sphere") && numberOfCollisions >= nombreDeHp)
        {
            Destroy(gameObject);
            scoreObject.changeScore(scoreDeDestruction);
        }
    }
}
