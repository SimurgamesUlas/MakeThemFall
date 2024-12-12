using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    void Start()
    {
        
    }

    
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void GameOver(){
        SceneManager.LoadScene(0);
    }
}
