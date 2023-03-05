using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestPanelManager : MonoBehaviour
{
    [SerializeField] CharacterStats charStats;
    public TextMeshProUGUI textMeshProUGUI_Title;
    public TextMeshProUGUI textMeshProUGUI_Destripcion;
    public TextMeshProUGUI textMeshProUGUI_XPReward;
    public void setQuestValue(QuestInfo questInfo)
    {
        textMeshProUGUI_Title.text = questInfo.Title;
        textMeshProUGUI_Destripcion.text = questInfo.Description.Replace("CHARACTER_NAME_INSERT_THIS", charStats.Name);
        textMeshProUGUI_XPReward.text = questInfo.XPReward.ToString();
    }

    public void open()
    {

        this.gameObject.SetActive(true);
    }
    public void close()
    {
        this.gameObject.SetActive(false);
    }
}
