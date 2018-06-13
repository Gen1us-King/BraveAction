using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Weaponproperties : MonoBehaviour {

    public int Id;
    public int Value;//消耗MP的值
    public string Name;
    public string ItemType;
    public string Description;
    public Sprite Icon; 
    public int Damege;

    public Weapon weapon;
    // Use this for initialization
    void Start () {
        weapon = new Weapon(Id, Value, Name, Description, Icon, ItemType, Damege);
	}
}
