using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item {

    public int Damege { get; protected set; }

    public Weapon(int Id, int Value, string Name, string Description, Sprite Icon,string ItemType,int Damege) :
        base(Id,Value,Name,  Description, Icon, ItemType)
    {
        this.Damege = Damege;
    }
}
