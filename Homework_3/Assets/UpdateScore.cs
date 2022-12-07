using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    public static UpdateScore instance;

    public TextMeshProUGUI scoreText;

    int score = 0;

    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Collected: " + score.ToString();    
    }

    
    public void AddPoint(){
        score += 1;
        scoreText.text = "Collected: " + score.ToString();    
    }
}
