using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Rune : Item
{
    public int lvl;// Las runas tienen niveles del 1 al 9 y dependiendo de la rareza su poder es mas fuerte.
    public int power;
    public Element element;// Elemento de la runa
}