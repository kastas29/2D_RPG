using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DleteScriptChangeDungeon : MonoBehaviour
{
    [SerializeField] DefaultScenePosition defaultScenePosition;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(transform.name);
        if (transform.name == "TriggerDungeonBoss")
        {
            SceneManager.LoadScene("DungeonBoss");
        }
        else if (transform.name == "TriggerDungeon (1)")
        {
            SceneManager.LoadScene("Dungeon 1");
        }

    }
}
