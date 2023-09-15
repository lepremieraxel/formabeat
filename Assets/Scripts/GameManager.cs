using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject cameraBorder;
    public CinemachineVirtualCamera cinemachine;
    public GameObject playButton;
    public TextMeshProUGUI winText;
    public GameObject logo;
    public GameObject game;
    public GameObject background;
    public GameObject player;
    public GameObject gameOverScreen;
    private Vector3 playerStartPos;
    public GameObject postProcessingCamera;
    public Rigidbody2D dotFalling;
    public Text chrono;
    [SerializeField] float timer;
    public bool isPlaying;
    private Vector3 dotStartPos;
    // Start is called before the first frame update
    void Start()
    {
        isPlaying = false;
        playerStartPos = player.transform.position;
        postProcessingCamera.SetActive(false);
        timer = 0f;
        dotStartPos = dotFalling.transform.position;
    }

    public void Play()
    {
        timer = 0f;
        isPlaying = true;
        gameOverScreen.SetActive(false);
        playButton.SetActive(false);
        cinemachine.m_Lens.OrthographicSize = 20f;
        cinemachine.transform.position = new Vector3(-270.8f, -20.40f, -10f);
        cameraBorder.SetActive(true);
        logo.SetActive(false);
        game.SetActive(true);
        background.SetActive(true);
        cinemachine.m_Follow = player.transform;
        dotFalling.transform.position = dotStartPos;
    }

    public void GameOver()
    {
        isPlaying = false;
        gameOverScreen.SetActive(true);
        player.transform.position = playerStartPos;
        cinemachine.transform.position = new Vector3(22.4f, -20.4f, -10f);
        cinemachine.m_Lens.OrthographicSize = 256.95f;
        cameraBorder.SetActive(false);
        logo.SetActive(true);
        game.SetActive(false);
        background.SetActive(false);
        cinemachine.m_Follow = null;
        playButton.SetActive(false);
    }

    public void Win()
    {
        isPlaying = false;
        cinemachine.transform.position = new Vector3(22.4f, -20.4f, -10f);
        cinemachine.m_Lens.OrthographicSize = 256.95f;
        cameraBorder.SetActive(false);
        logo.SetActive(true);
        game.SetActive(false);
        background.SetActive(false);
        cinemachine.m_Follow = null;
        playButton.SetActive(false);
        winText.SetText("YOU WIN : "+Math.Round(timer).ToString()+"sec");
        postProcessingCamera.SetActive(true);
        chrono.text = "";
    }

    public void Quitter()
    {
        Application.Quit();
    }
    void FixedUpdate()
    {
        if (isPlaying)
        {
            timer += Time.fixedDeltaTime;
            chrono.text = Math.Round(timer).ToString();
        }
    }
}
