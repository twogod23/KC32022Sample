using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class ItemData
{
    public string ItemName;
    public int ItemY;
    public int ItemM;
    public int ItemD;
    public int ItemND;
}
public class ItemSaveJsonScript : MonoBehaviour
{
    //登録ボタンを押したときの処理
    public void select()
    {
        StreamWriter writer;
        
        ItemData itemData = new ItemData();
        itemData.ItemName = ItemRegisterScript.RegIName();
        itemData.ItemY = ItemRegisterScript.RegIY();
        itemData.ItemM = ItemRegisterScript.RegIM();
        itemData.ItemD = ItemRegisterScript.RegID();
        itemData.ItemND = ItemRegisterScript.RegIND();

        string jsonstr = JsonUtility.ToJson(itemData);

        writer = new StreamWriter(Application.dataPath + "/savedata.json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
        
        Debug.Log(jsonstr);
    }
}