using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CryptoBike;

public class PauseMenu : MonoBehaviour
{

    public GameObject optionsScreen, pauseScreen;

    public string mainMenuScene;

    private bool isPaused;

    public GameObject loadingScreen, loadingIcon, progressBar, crosshair;
    public Text loadingText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUnpause();
            //EnableFPS(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        
    }

    public void PauseUnpause()
    {
        if (!isPaused)
        {
            pauseScreen.SetActive(true);
            isPaused = true;

            progressBar.SetActive(false);
            crosshair.SetActive(false);

            Time.timeScale = 0f;
        }
        else
        {
            pauseScreen.SetActive(false);
            isPaused = false;

            progressBar.SetActive(true);
            crosshair.SetActive(true);

            Time.timeScale = 1f;
        }
    }


    public void DisableInteractionUI()
    {

    }

    /*
    public void EnableFPS(bool enable)
    {
        GameObject fpsObj = GameObject.Find("CharacterController");
        FirstPersonController fpsScript = fpsObj.GetComponent<FirstPersonController>();

        if (enable)
        {
            //Enable FPS script
            fpsScript.enabled = true;
        }
        else
        {
            //Disable FPS script
            fpsScript.enabled = false;
            //Unlock Mouse and make it visible
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    */

    public void OpenOptions()
    {
        optionsScreen.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsScreen.SetActive(false);
    }

    public void QuitToMain()
    {
        //SceneManager.LoadScene(mainMenuScene);

        //Time.timeScale = 1f;

        StartCoroutine(LoadMain());
    }

    public IEnumerator LoadMain()
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(mainMenuScene);

        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            if(asyncLoad.progress >= .9f)
            {
                loadingText.text = "Press any key to continue";
                loadingIcon.SetActive(false);

                if (Input.anyKeyDown)
                {
                    asyncLoad.allowSceneActivation = true;

                    Time.timeScale = 1f;
                }
            }
            yield return null;
        }
                
    }
}
