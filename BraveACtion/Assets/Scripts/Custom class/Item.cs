using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item{

    public int Id { get; private set; }
    public int Value { get; private set; }//Consumable的值
    public string Name { get; private set; }
    public string Description { get; private set; }
    public Sprite Icon { get; private set; }
    public string ItemType { get; protected set; }
    public Item(int Id,int Value,string Name,string Description,Sprite Icon,string ItemType)
    {
        this.Id = Id;
        this.Value = Value;
        this.Name = Name;
        this.Description = Description;
        this.Icon = Icon;
        this.ItemType = ItemType;
    }
}
