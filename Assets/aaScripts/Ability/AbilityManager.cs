using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AbilityManager : MonoBehaviour
{
    public GameObject AbilityTitle;
    public GameObject AbilityDescription;

    // Start is called before the first frame update

    public void UpdateInformation(Ability abilityInfo)
    {
        AbilityTitle.GetComponent<TextMeshProUGUI>().text = abilityInfo.title;
        AbilityDescription.GetComponent<TextMeshProUGUI>().text = abilityInfo.description;
    }
}
