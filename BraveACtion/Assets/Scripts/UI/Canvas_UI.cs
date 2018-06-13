using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//该脚本用于canvas下的子物体实例化函数定义和设置画布场景加载不销毁
public class Canvas_UI : MonoBehaviour {

    public GameObject Dialoguebox;
    public GameObject BackPack;
    private void Awake()
    {
        
    }
    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public  GameObject Instantiate_Dialoguebox(float t) {
        GameObject Dia;
        Dia = Instantiate(Dialoguebox, transform);
        Destroy(Dia, t);
        return Dia;
    }
    public GameObject Instantiate_BackPack()
    {
        GameObject Back;
        Back = Instantiate(BackPack, transform);
        return Back;
    }
}
