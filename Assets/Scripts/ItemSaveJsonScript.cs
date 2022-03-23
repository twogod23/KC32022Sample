using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class ItemDataWrapper
{
    public ItemData itemData;
}

[System.Serializable]
public class ItemData
{
    public string ItemName;
    public int ItemV;
    public int ItemY;
    public int ItemM;
    public int ItemD;
    public int ItemND;
}
public class ItemSaveJsonScript : MonoBehaviour
{
    public List<string> itemdatalist;
    
    [SerializeField]
    ItemDataWrapper itemDatasWrap;

    //登録ボタンを押したときの処理
    public void select()
    {
        StreamWriter writer;
        
        
        //クラス内にデータをセット
        ItemData itemData = new ItemData();
        itemData.ItemName = ItemRegisterScript.RegIName();
        itemData.ItemV = ItemRegisterScript.RegIV();
        itemData.ItemY = ItemRegisterScript.RegIY();
        itemData.ItemM = ItemRegisterScript.RegIM();
        itemData.ItemD = ItemRegisterScript.RegID();
        itemData.ItemND = ItemRegisterScript.RegIND();

        ItemDataWrapper itemDatasWrap = new ItemDataWrapper();

        

        //jsonフォーマットに変換
        string jsonstr = JsonUtility.ToJson(itemDatasWrap);

        itemdatalist.Add(jsonstr);

        string listjsonstr = JsonUtility.ToJson(itemdatalist);

        //ファイルの保存
        writer = new StreamWriter(Application.dataPath + "/savedata.json", true);
        writer.Write(listjsonstr);
        writer.Flush();
        writer.Close();
        
        Debug.Log(listjsonstr);
    }
}