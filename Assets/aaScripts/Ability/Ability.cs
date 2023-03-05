using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu]
public class Ability : ScriptableObject
{
    public Sprite iconSprite;
    public string title;
    public string description;
    public int cooldown;
    public void cast(){}
    public void showInformation(GameObject DescriptionBox){}

}
