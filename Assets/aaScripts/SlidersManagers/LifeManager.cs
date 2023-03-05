using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public CharacterStats characterStats;
    public Slider slider;
    void Start()
    {
        slider.maxValue = characterStats.Hp_max;
        onSliderCharged();
    }

    public void onSliderCharged()
    {
        slider.value = characterStats.Hp;
    }


    public void setHp(int value)
    {
        characterStats.Hp += value;
        if (characterStats.Hp > characterStats.Hp_max)
        {
            characterStats.Hp = characterStats.Hp_max;
        }
        else if (characterStats.Hp < 0)
        {
            characterStats.Hp = 0;
        }
        onSliderCharged();
    }
    public void setMaxHp(int value)
    {
        characterStats.Hp_max += value;
        slider.maxValue = characterStats.Hp_max;
    }
}
