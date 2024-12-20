using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text collectiblesNumberstext;

    private int collectiblesNumber;

    public TMP_Text totalCollectiblesNumberText;

    private int totalCollectiblesNumber;

    public AudioSource audioSource; 
    
    void Start()
    {
        totalCollectiblesNumber = transform.childCount;
        totalCollectiblesNumberText.text = totalCollectiblesNumber.ToString();
    }

    
    void Update()
    {
        if (transform.childCount <= 0)
        {
            Debug.Log("WIN");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void AddCollectible()
    {
        audioSource.Play();

        collectiblesNumber++;
        collectiblesNumberstext.text = collectiblesNumber.ToString();
    }
}
