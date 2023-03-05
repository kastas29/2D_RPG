using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceManager : MonoBehaviour
{
    public CharacterStats characterStats;
    public Slider slider;
    void Start()
    {
        PlayerManager.Instance.sliderExperienceEvent.AddListener(onSliderCharged);
        slider.maxValue = characterStats.Xp_nextLevel;
        onSliderCharged();
    }



    public void onSliderCharged()
    {
        slider.value = characterStats.Xp;
    }

    public void onSliderMaxCharged()
    {
        slider.maxValue = characterStats.Xp_nextLevel;
        onSliderCharged();
    }


}
