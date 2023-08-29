using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void OnSelectGalleryFreeLook()
    {
        SceneManager.LoadScene(1);
    }

    public void OnSelectGalleryCinematic()
    {
        SceneManager.LoadScene(2);
    }
}
