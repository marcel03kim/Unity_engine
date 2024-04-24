using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{

    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;

    private float surviveTime;
    private bool isGameover;
    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Keycode.Esc))
        {
            SceneManager.LoadScene("PauseScene");
        }
        if (!isGameover)
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R)) 
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }
    
    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);
    }
}
