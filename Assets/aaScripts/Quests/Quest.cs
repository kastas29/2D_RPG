using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quest : MonoBehaviour
{
    [SerializeField] public QuestInfo questInfo;
    public QuestPanelManager questPanelManager;

    public void showQuest()
    {
        questPanelManager.setQuestValue(questInfo);
        questPanelManager.open();
    }
    public void closeQuest()
    {
        questPanelManager.close();
    }
}
