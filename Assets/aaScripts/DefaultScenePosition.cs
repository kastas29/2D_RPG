using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class DefaultScenePosition : ScriptableObject {
    [SerializeField] Vector3 position;
    [SerializeField] string sceneName;

    public Vector3 Position { get => position; set => position = value; }
    public string SceneName { get => sceneName; set => sceneName = value; }
}
