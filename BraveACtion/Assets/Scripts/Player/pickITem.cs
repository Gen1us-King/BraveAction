using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//该脚本用于捡物体，是人物子物体的脚本；
public class pickITem : MonoBehaviour {
    private Canvas_UI Canvas_UI;
    private Weapon weapon;
    private GameObject Back;
      // Use this for initialization
    void Start () {
        Canvas_UI = GameObject.Find("Canvas_UI").GetComponent<Canvas_UI>();
        Back = Canvas_UI.Instantiate_BackPack();//实例化背包
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.F))
        {
            Back.GetComponent<BackPack>().Weaponlassification(weapon);
        }
    }//按F拾取物体
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "weapon")
        {
            weapon = collision.GetComponent<Weaponproperties>().weapon;
            Canvas_UI.Instantiate_Dialoguebox(5).GetComponentInChildren<Text>().text
             = "名字: " + weapon.Name + " 消耗：" + weapon.Value + " 伤害：" + weapon.Damege + "\nF 拾取";
            //先调用Canvas_UI的Instantiate_Dialoguebox实例化一个10秒后销毁的对话框，在获取对话框Text；
        }
    }
}
