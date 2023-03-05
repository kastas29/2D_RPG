using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void ChangeScene(string scene_name) // Change to scene_name Scene
    {
        SceneManager.LoadScene(scene_name);
    }

    public void OpenClosePanel(GameObject panel) // ACtivates or deactivates the GameObject
    {
        if(panel.activeSelf == true)
        {
            panel.SetActive(false);
        } else
        {
            panel.SetActive(true);
        }
    }

}
