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

    AudioSource gameOverAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0;
        isGameover = false;
        gameOverAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameover)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time : " + (int) surviveTime;
            gameoverText.SetActive(false);
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R)) 
            {
                SceneManager.LoadScene("Dodge_scene");
            }
        }
    }
    
    public void EndGame()
    {
        gameOverAudioSource.Play();
        isGameover = true;
        gameoverText.SetActive(true);
        //BestTime Ű�� ���� �� ���������� �ְ� ����� ��������
        float bestTime = PlayerPrefs.GetFloat("BestTime");
        //���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if (surviveTime > bestTime) 
        {
            bestTime = surviveTime;
            //���� �� �ְ� ����� BestTime Ű�� ����
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        recordText.text = "BestTime : " + (int)bestTime;
    }
}
