using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OdinSave : ScriptableObject
{
    [SerializeField] List<Item> items = new List<Item>();
    [SerializeField] Equip[] equipment = new Equip[8];
    [SerializeField] Backpack[] backpacks = new Backpack[4];

    [SerializeField] CharacterStats characterStats;
    [SerializeField] string sceneName;
    [SerializeField] Vector3 position;





    public List<Item> Items { get => items; set => items = value; }
    public Equip[] Equipment { get => equipment; set => equipment = value; }
    public Backpack[] Backpacks { get => backpacks; set => backpacks = value; }
    public CharacterStats CharacterStats { get => characterStats; set => characterStats = value; }
    public string SceneName { get => sceneName; set => sceneName = value; }
    public Vector3 Position { get => position; set => position = value; }
}
