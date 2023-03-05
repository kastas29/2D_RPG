using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShieldManager : MonoBehaviour
{
    public CharacterStats characterStats;
    public Slider slider;
    void Start()
    {
        slider.maxValue = characterStats.Shield_max;
        StartCoroutine(FillShield());
        onSliderCharged();
    }

    IEnumerator FillShield()
    {
        while (characterStats.Shield < characterStats.Shield_max)
        {
            yield return new WaitForSeconds(10f);
            if (characterStats.Shield_max > 0)
            {
                if (characterStats.Shield < characterStats.Shield_max)
                {
                    setShield(characterStats.Shield_max / 10);
                }
            }
        }
    }

    public void onSliderCharged()
    {
        slider.value = characterStats.Shield;
    }


    public void setShield(int value)
    {
        if (value > 0)
        {
            characterStats.Shield += value;
            if (characterStats.Shield > characterStats.Shield_max)
            {
                characterStats.Shield = characterStats.Shield_max;
            }
        }
        else
        {
            if (characterStats.Shield == characterStats.Shield_max)
            {
                characterStats.Shield += value;
                StartCoroutine(FillShield());
            }
            else
            {
                characterStats.Shield += value;
            }
        }
        onSliderCharged();
    }

    // Fase beta a saber que coño pasa cuando aumentemos la armadura maxima
    public void setMaxShield(int value)
    {
        characterStats.Shield_max += value;
        slider.maxValue = characterStats.Shield_max;
    }
}
