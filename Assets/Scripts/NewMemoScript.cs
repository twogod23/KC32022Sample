//新たに登録されるメモの情報を読み取るためのスクリプト（ItemRegisterScript）
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class NewMemoScript : MonoBehaviour
{
    //InputFieldを格納するための変数
    InputField infMTitle;
    InputField infMMemo;

    //取得したテキストを代入するための変数
    public static string MTitle;
    public static string MMemo;


    // Start is called before the first frame update
    void Start()
    {
        //InputFieldコンポーネントを取得
        infMTitle = GameObject.Find("IFTitle").GetComponent<InputField>();
        infMMemo = GameObject.Find("IFMemo").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetInformation()
    {
        //取得したテキストを代入
        MTitle = infMTitle.text;
        MMemo = infMMemo.text;
    }

    //代入した値を別のスクリプトで使うための設定
    public static string RegMT()
    {
        return MTitle;
    }
    public static string RegMM()
    {
        return MMemo;
    }
}
