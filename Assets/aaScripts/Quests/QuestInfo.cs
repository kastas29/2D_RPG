using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class QuestInfo : ScriptableObject
{
    public string Title;
    public string Description;
    public Item itemReward;
    public int XPReward;
}
