using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTrigger : MonoBehaviour
{
    [SerializeField] DefaultScenePosition DefaultScenePosition;
    [SerializeField] PlayerPosition PlayerPosition;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            PlayerPosition.Position = DefaultScenePosition.Position;
            SceneManager.LoadScene(DefaultScenePosition.SceneName);
        }
    }
}
