using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public bool isPaused = false;
    public AudioSource cheer;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //restart
            SceneManager.LoadScene("MainMenu");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //restart
            print(Movimiento.onPause);
            MyPause();
            Movimiento.onPause = isPaused;
            //Movimiento.onPause = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;
            if (Physics.Raycast(myRay, out hitInfo, 10.0f))
            {
                if (hitInfo.collider.gameObject.CompareTag("Lava"))
                    Destroy(hitInfo.collider.gameObject);
            }
        }
    }

    public void Level1()
    {

        ScoringSystem.theScore = 0;
        cheer.Play();
        SceneManager.LoadScene("SampleScene");
    }

    //    public void ExitGame()
    //    {
    //#if UNITY_EDITOR
    //        UnityEditor.EditorApplication.isPlaying=false;

    //#else
    //        Application.Quit();

    //#endif
    //    }


    public void MyPause()
    {
        if (isPaused)
        {
            if (pauseMenu) pauseMenu.SetActive(false);
            Time.timeScale = 1.0f;
            isPaused = !isPaused;
        }
        else
        {
            if (pauseMenu) pauseMenu.SetActive(true);
            Time.timeScale = 0.0f;
            isPaused = !isPaused;

        }

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
