//メモのセーブデータを管理するためのスクリプト（SaveJson）
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

[Serializable]
public class MemoDataList{
    public List<MemoData> memoDatas;
    public MemoDataList(){
        memoDatas = new List<MemoData>();
    }
}

public class MemoSaveJsonScript : MonoBehaviour
{
    string filePath;
    MemoDataList save;

    void Awake()
    {
        //変数の初期化処理を行う
        filePath = Application.persistentDataPath + "/" + ".memosavedata.json"; 
        save = new MemoDataList();
        Load();
    }

    //ItemDataを引数に呼び出すとListを更新しJsonに登録します
    public void Save(MemoData memo)
    {
        save.memoDatas.Add(memo);

        Debug.Log(filePath);
        string json = JsonUtility.ToJson(save);
        StreamWriter streamWriter = new StreamWriter(filePath);
        streamWriter.Write(json); streamWriter.Flush();
        streamWriter.Close();
    }


    //JsonからロードしてItemDataのListを返す
    //Jsonファイルが存在しない場合はnullを返す
    public List<MemoData> Load()
    { 
        if (File.Exists(filePath))
        {
            StreamReader streamReader;
            streamReader = new StreamReader(filePath);
            string data = streamReader.ReadToEnd();
            streamReader.Close();
            save = JsonUtility.FromJson<MemoDataList>(data);
            Debug.Log(save.memoDatas);
            return save.memoDatas;
        }
        return null;
    }

}