using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    
    public static UIController instant;
    public static bool GameIsPause = false;
    
    [Header("Play")]
    [SerializeField] private GameObject PlayUI;
    [Header("GameOver")]
    [SerializeField] private GameObject GameOverUI;
    [Header("Winner")]
    [SerializeField] private GameObject WinnerUI;
    [Header("Pause")]
    [SerializeField] private GameObject PauseMenuUI;
    [Header("Score")]
    [SerializeField] private float totalTime = 180f;
    [SerializeField] private Text textTime;
    [SerializeField] private Text textTimeWin;
    public float currenTime;
    int score;
    private void Awake()
    {
        if (instant == null)
        {
            instant = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currenTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instant.isGameDone == false && GameController.instant.isPause == false)
        {
            currenTime -= 1 * Time.deltaTime;
            score = (int)currenTime;
            textTime.text = "Time: " + score.ToString();

        }
        if (currenTime <= 0)
        {
            GameController.instant.isGameDone = true;
            GameOver();
        }

    }
    public void Resume()
    {
        GameController.instant.isPause = false;
        PlayUI.SetActive(true);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    public void Pause()
    {
        GameController.instant.isPause = true;
        PlayUI.SetActive(false);
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public void GameOver()
    {
        //Debug.Log("GameOver");
        PlayUI.SetActive(false);
        GameOverUI.SetActive(true);

    }
    public void Winner()
    {
        //Debug.Log("Winner");
        PlayUI.SetActive(false);
        WinnerUI.SetActive(true);
        textTimeWin.text = "Time: " + score.ToString();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
}
