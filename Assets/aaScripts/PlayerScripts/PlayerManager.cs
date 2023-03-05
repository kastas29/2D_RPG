using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static UnityEditor.Progress;

public class PlayerManager : MonoBehaviour, HurtBoxInterface
{
    public static PlayerManager Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        GetComponent<SpriteRenderer>().sprite = characterStats.Sprite;
        transform.position = playerPosition.Position;

    }

    public CharacterStats characterStats;
    public BaseStats baseStats;
    [SerializeField] PlayerPosition playerPosition;
    public UnityEvent interactionEvents;

    public UnityEvent sliderExperienceEvent;
    public UnityEvent sliderHpEvent;
    public UnityEvent sliderManaEvent;
    public UnityEvent sliderShieldEvent;
    public UnityEvent sliderStaminaEvent;

    Vector2 movement;
    private Rigidbody2D rigidBody;

    public enum QuestStates { DONE, DOING, TODO } // THE QUEST IS CURRENTLY DONE, BEING DONE OR NEVER STARTED
    public Dictionary<QuestInfo, QuestStates> QuestProgression; // THIS DICTIONARY STORES A QUEST AND ITS CURRENT STATE

    public void addQuest(QuestInfo quest, QuestStates questState)
    {
        this.QuestProgression.Add(quest, questState);
    }


    // MOVEMENT
    public void Move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movement * characterStats.Speed * Time.fixedDeltaTime);
        if (movement.x > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (movement.x < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
    // END MOVEMENT
    public void Interact()
    {
        if (interactionEvents != null)
        {
            interactionEvents.Invoke();
        }
    }

    public void Attack(InputAction.CallbackContext context)
    {
        print("entra");
        GetComponent<Animator>().Play("PlayerAtck");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == "Mision")
        {
            Quest q = collision.GetComponent<Quest>();
            q.showQuest();
        }

        if (collision.transform.tag == "Item")
        {
            collision.GetComponent<ItemScript>().TakeItem();
        }

        if (collision.transform.tag == "DungeonTrigger")
        {
            SceneManager.LoadScene("Dungeon");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Mision")
        {
            Quest q = collision.GetComponent<Quest>();
            q.closeQuest();
        }
    }


    //HITBOX AND HURTBOX 

    public void getDmg(int dmg)
    {
        characterStats.Hp -= dmg;
        if (sliderHpEvent != null)
        {
            sliderHpEvent.Invoke();
        }
    }
    //END HITBOX AND HURTBOX

    public int getAttackDmg()
    {
        int attackDmg = 0;
        if (getCriticalAttack() > UnityEngine.Random.Range(0, 1f))
        {
            attackDmg = (int)((characterStats.Dmg + Equipment.Instance.getEquipmentDmg() + Equipment.Instance.getEquipmentCriticalDmg()) * 1.25f);
        }
        else
        {
            attackDmg = characterStats.Dmg + Equipment.Instance.getEquipmentDmg();
        }
        print("ATTACK DMG: " + attackDmg);
        return attackDmg;
    }

    public float getCriticalAttack()
    {
        float criticalPercent = (characterStats.CriticalPercent + Equipment.Instance.getEquipmentCriticalPercent()) / 100;
        print("CRITICAL PERCENT: " + criticalPercent);
        return criticalPercent;
    }

    public void reloadPosition()
    {
        transform.position = playerPosition.Position;
    }

    // relativo a la experiencia
    public void receiveExperience(int value)
    {
        characterStats.Xp += value;
        if (characterStats.Xp > characterStats.Xp_nextLevel)
        {
            characterStats.Xp = characterStats.Xp_nextLevel;
            setMaxXp();
            characterStats.Xp = 0;
            levelUp();
        }
        if (sliderExperienceEvent != null)
        {
            sliderExperienceEvent.Invoke();

        }
    }

    public void setMaxXp()
    {
        characterStats.Xp_nextLevel = (int)(characterStats.Xp_nextLevel * 1.1f);
        GameManager.Instance.GetComponent<ExperienceManager>().onSliderMaxCharged();
    }



    public void levelUp()
    {
        characterStats.Level++;
    }
    // fin experiencia






}
