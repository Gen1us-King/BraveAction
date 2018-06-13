using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//该脚本用于武器分类存储，以及backpack物体的render方面；
public class BackPack : MonoBehaviour {
    public Weapon[] weapons = new Weapon[3]; 
    public Consumable[] consumables=new Consumable[2];
    private Component[] CanvasRenderers;
    private int Hp_count;
    private int Mp_count;
	// Use this for initialization
	void Start () {
        CanvasRenderers = GetComponentsInChildren<CanvasRenderer>(false);//获取所有子物体的CanvasRenderer
        SetCanvasRendersAlpha(0f);//先将Alpha设置为0 ，达到隐藏的效果；
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SetCanvasRendersAlpha(1f);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            SetCanvasRendersAlpha(0f);
        }

    }
    public void Weaponlassification(Weapon weapon)
    {
        if (weapon.ItemType== "MainWeapon")
        {
            weapons[0] = weapon;
            transform.Find("MainWeapon").GetComponent<Image>().sprite = weapons[0].Icon;
        }
        else if (weapon.ItemType == "SubWeapon")
        {
            weapons[1] = weapon;
            transform.Find("SubWeapon").GetComponent<Image>().sprite = weapons[1].Icon;
        }
        else
        {
            weapons[2] = weapon;
            transform.Find("Bomb").GetComponent<Image>().sprite = weapons[1].Icon;
        }

    }
    private void SetCanvasRendersAlpha(float state)
    {
        foreach(CanvasRenderer i in CanvasRenderers){
            i.SetAlpha(state);
        }
    }
}
