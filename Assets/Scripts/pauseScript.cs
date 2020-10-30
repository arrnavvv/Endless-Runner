using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pauseScript : MonoBehaviour
{
    public GameObject pauseCanvas;
    private bool isPlaying = true;

    // Start is called before the first frame update
    void Start()
    {
        pauseCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (isPlaying)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

  public  void Pause()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        isPlaying = false;
    }

   public void Resume()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        isPlaying = true;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void goToMainMenu()
    {
        pauseCanvas.SetActive(false);
        isPlaying = true;
        SceneManager.LoadScene("TITLE SCREEN");
    }
}
