using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pilah : MonoBehaviour
{
    public string nameTag;
    public Text scoreText;
    public AudioClip audioCorrect;
    public AudioClip audioWrong;
    private AudioSource correctSource;
    private AudioSource wrongSource;
   
    // Start is called before the first frame update
    void Start()
    {
        correctSource = gameObject.AddComponent<AudioSource>();
        correctSource.clip = audioCorrect;

        wrongSource = gameObject.AddComponent<AudioSource>();
        wrongSource.clip = audioWrong;

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals(nameTag))
        {
            ScoreData.score += 20;
            scoreText.text = ScoreData.score.ToString();
            Destroy(collision.gameObject);
            correctSource.Play();
        }
        else
        {
            ScoreData.score -= 5;
            scoreText.text = ScoreData.score.ToString();
            Destroy(collision.gameObject);
            wrongSource.Play();
        }
    }
}
