using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item {
    public int BackHP { get; protected set; }
    public int BackMP { get; protected set; }
    public Consumable(int Id, int Value, string Name, string Description, Sprite Icon, string ItemType,int BackHP,int BackMP):
        base(Id,Value,  Name,  Description,  Icon, ItemType)
    {
        base.ItemType = "Consumable";
        this.BackHP = BackHP;
        this.BackMP = BackMP;
    }
}
