using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using OdinSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveGameOdin : MonoBehaviour
{
    public static SaveGameOdin Instance;
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
    [SerializeField] OdinSave odinSave;


    [SerializeField] InventoryContent inventory;
    [SerializeField] EquipmentContent equipment;
    [SerializeField] CharacterStats characterStats;

    [SerializeField] GameSlot gameSlot;
    [SerializeField] PlayerPosition playerPosition;


    public void saveGame()
    {
        print("Guardando");
        string gameSlotFile = gameSlot.SlotName + ".json";


        // guardamos todos los items que tiene el jugador en su inventario o equipados.
        odinSave.Items.Clear();
        for (int i = 0; i < inventory.Items.Count; i++)
        {
            odinSave.Items.Add(inventory.Items[i]);
        }
        for (int i = 0; i < equipment.CharacterEquipment.Length; i++)
        {
            odinSave.Equipment[i] = equipment.CharacterEquipment[i];
        }
        for (int i = 0; i < equipment.Backpacks.Length; i++)
        {
            odinSave.Backpacks[i] = equipment.Backpacks[i];
        }

        odinSave.CharacterStats = characterStats;
        odinSave.Position = GameObject.Find("Player").transform.position;
        odinSave.SceneName = SceneManager.GetActiveScene().name;

        byte[] odinSaveSerialized = SerializationUtility.SerializeValue<OdinSave>(odinSave, DataFormat.JSON);
        string gameData = System.Convert.ToBase64String(odinSaveSerialized);
        File.WriteAllText(gameSlotFile, gameData);

        GameManager.Instance.GetComponent<MenuManager>().ChangeScene("MainMenu");
    }


    public void loadGame(string gameSlotName)
    {
        print("Cargando partida");
        string gameSlotFile = gameSlotName + ".json";

        string gameData = File.ReadAllText(gameSlotFile);
        byte[] data = System.Convert.FromBase64String(gameData);
        OdinSave odinSaveData = SerializationUtility.DeserializeValue<OdinSave>(data, DataFormat.JSON);
        if (odinSaveData == null)
        {
            GameManager.Instance.GetComponent<MenuManager>().ChangeScene("CharacterSelection");
        }
        else
        {
            inventory.Items = odinSaveData.Items;
            equipment.CharacterEquipment = odinSaveData.Equipment;
            equipment.Backpacks = odinSaveData.Backpacks;
            playerPosition.Position = odinSaveData.Position;
            print(odinSaveData.SceneName);
            GameManager.Instance.GetComponent<MenuManager>().ChangeScene(odinSaveData.SceneName);
        }


    }


    public void defaultGame(string gameSlotName, OdinSave defaultData, CharacterStats characterStats)
    {
        print("Borrando partida");
        string gameSlotFile = gameSlotName + ".json";

        OdinSave odinSaveDataDefault = defaultData;
        odinSaveDataDefault.CharacterStats = characterStats;
        byte[] odinSaveSerialized = SerializationUtility.SerializeValue<OdinSave>(defaultData, DataFormat.JSON);
        string gameData = System.Convert.ToBase64String(odinSaveSerialized);
        File.WriteAllText(gameSlotFile, gameData);

    }
}
