using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject cameraBorder;
    public CinemachineVirtualCamera cinemachine;
    public GameObject playButton;
    public GameObject winText;
    public GameObject logo;
    public GameObject game;
    public GameObject background;
    public GameObject player;
    public GameObject gameOverScreen;
    private Vector3 playerStartPos;
    public GameObject postProcessingCamera;
    // Start is called before the first frame update
    void Start()
    {
        playerStartPos = player.transform.position;
        postProcessingCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        gameOverScreen.SetActive(false);
        playButton.SetActive(false);
        cinemachine.m_Lens.OrthographicSize = 20f;
        cinemachine.transform.position = new Vector3(-270.8f, -20.40f, -10f);
        cameraBorder.SetActive(true);
        logo.SetActive(false);
        game.SetActive(true);
        background.SetActive(true);
        cinemachine.m_Follow = player.transform;
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        player.transform.position = playerStartPos;
    }

    public void Win()
    {
        cinemachine.transform.position = new Vector3(22.4f, -20.4f, -10f);
        cinemachine.m_Lens.OrthographicSize = 256.95f;
        cameraBorder.SetActive(false);
        logo.SetActive(true);
        game.SetActive(false);
        background.SetActive(false);
        cinemachine.m_Follow = null;
        playButton.SetActive(false);
        winText.SetActive(true);
        postProcessingCamera.SetActive(true);
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
