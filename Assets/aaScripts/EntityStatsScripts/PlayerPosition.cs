using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerPosition : ScriptableObject
{
    [SerializeField] Vector3 position;

    public Vector3 Position { get => position; set => position = value; }
}