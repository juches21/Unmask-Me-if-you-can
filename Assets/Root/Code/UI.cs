using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public GameObject UIpause;

    public GameObject Video;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PauseGame()
    {
        UIpause.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ReturnGame()
    {
        UIpause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }


    public void LoadPlay()
    {
        Video.SetActive(true);
        StartCoroutine(PlayGame());
    }

    IEnumerator PlayGame()
    {
        yield return new WaitForSeconds(25f);
        SceneManager.LoadScene(1);

    }
}
