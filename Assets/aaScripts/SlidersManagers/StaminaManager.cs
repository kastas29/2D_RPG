using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class StaminaManager : MonoBehaviour
{
    public CharacterStats characterStats;
    public GameObject sliderGameObject;
    public Slider slider;
    void Start()
    {
        slider.maxValue = characterStats.Stamina_max;
        StartCoroutine(FillStamina());
        onSliderCharged();
    }

    IEnumerator FillStamina()
    {
        sliderGameObject.SetActive(true);
        while (characterStats.Stamina < characterStats.Stamina_max)
        {
            yield return new WaitForSeconds(characterStats.Stamina_regenVelocity);


            setStamina(1);

        }
        sliderGameObject.SetActive(false);
    }

    public void onSliderCharged()
    {
        slider.value = characterStats.Stamina;
        if (characterStats.Stamina == characterStats.Stamina_max)
        {
            sliderGameObject.SetActive(false);
        }
        slider.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = characterStats.Stamina.ToString();
    }

    public void setStamina(int value)
    {
        if (value > 0)
        {
            characterStats.Stamina += value;
            if (characterStats.Stamina > characterStats.Stamina_max)
            {
                characterStats.Stamina = characterStats.Stamina_max;
            }

        }
        else
        {
            if (characterStats.Stamina == characterStats.Stamina_max)
            {
                characterStats.Stamina += value;
                StartCoroutine(FillStamina());
            }
            else
            {
                characterStats.Stamina += value;
            }
        }
        onSliderCharged();
    }

    public void setMaxStamina(int value)
    {
        characterStats.Stamina_max += value;
        slider.maxValue = characterStats.Stamina_max;
    }
}
