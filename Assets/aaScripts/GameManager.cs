using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameObject Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
