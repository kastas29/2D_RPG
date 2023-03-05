using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ManaManager : MonoBehaviour
{
    public CharacterStats characterStats;
    public Slider slider;
    void Start()
    {
        slider.maxValue = characterStats.Mana_max;
        StartCoroutine(FillMana());
        onSliderCharged();
    }

    IEnumerator FillMana()
    {
        while (characterStats.Mana < characterStats.Mana_max)
        {
            yield return new WaitForSeconds(characterStats.Mana_regenVelocity);
            if (characterStats.Mana_max > 0)
            {
                if (characterStats.Mana < characterStats.Mana_max)
                {
                    setMana(1);
                }
            }
        }
    }

    public void onSliderCharged()
    {
        slider.value = characterStats.Mana;
    }


    public void setMana(int value)
    {
        if (value > 0)
        {
            characterStats.Mana += value;
            if (characterStats.Mana > characterStats.Mana_max)
            {
                characterStats.Mana = characterStats.Mana_max;
            }

        }
        else
        {
            if (characterStats.Mana == characterStats.Mana_max)
            {
                characterStats.Mana += value;
                StartCoroutine(FillMana());
            }
            else
            {
                characterStats.Mana += value;
            }
        }
        onSliderCharged();
    }

    // Fase beta a saber que coño pasa cuando aumentemos el mana maximo
    public void setMaxMana(int value)
    {
        characterStats.Mana_max += value;
        slider.maxValue = characterStats.Mana_max;
    }
}
