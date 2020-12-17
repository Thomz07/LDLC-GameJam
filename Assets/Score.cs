using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    float score;
    // Start is called before the first frame update
    public Text leTexte;
    void Start()
    {
        leTexte = GetComponent<Text>();
        leTexte.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScore(int modif)
    {
        score = score + modif;
        leTexte.text = score.ToString();
    }
}
