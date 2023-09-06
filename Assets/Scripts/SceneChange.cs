using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public static SceneChange instance;

    public void UOFreelook()
    {
        SceneManager.LoadScene(1);
        Cursor.visible = false;
    }

    public void UOCinematic()
    {
        SceneManager.LoadScene(2);
        Cursor.visible = false;
    }
    public void OFreelook()
    {
        SceneManager.LoadScene(3);
        Cursor.visible = false;
    }
    public void OCinematic()
    {
        SceneManager.LoadScene(4);
        Cursor.visible = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            MainMenu();
        }
    }
}
