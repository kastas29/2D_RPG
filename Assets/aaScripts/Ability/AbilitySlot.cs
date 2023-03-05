using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AbilitySlot : MonoBehaviour
{

    public Ability abilityInfo;

    void Start()
    {
        this.transform.GetChild(2).GetComponent<Image>().sprite = abilityInfo.iconSprite;
    }

    public void changeAbilityInformation()
    {
        this.transform.parent.parent.parent.gameObject.GetComponent<AbilityManager>().UpdateInformation(abilityInfo);
    }
}
