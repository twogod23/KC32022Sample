//クラスにまとめるためのスクリプト（ItemSaveJsonScript）
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class MemoData
{
    public string MemoTitle;
    public string MemoInfo;
}

public class MemoSaveScript : MonoBehaviour
{
    //登録ボタンを押したときの処理
    public void select()
    {
        MemoData memoDataWrap = new MemoData();
        memoDataWrap.MemoTitle = NewMemoScript.RegMT();
        memoDataWrap.MemoInfo = NewMemoScript.RegMM();
    }
}