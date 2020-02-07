using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public static MenuController instant;
    [SerializeField] private GameObject MenuUI;
    [SerializeField] private GameObject OptionUI;
    [SerializeField] private GameObject Player;

    private void Start()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OptionClicked()
    {
        MenuUI.SetActive(false);
        OptionUI.SetActive(true);
        Player.SetActive(true);
    }
    public void BackClicked()
    {
        OptionUI.SetActive(false);
        MenuUI.SetActive(true);
        Player.SetActive(false);
    }
    public void QuitClicked()
    {
        Debug.Log("Quiting...");
        Application.Quit();
    }
    
}
