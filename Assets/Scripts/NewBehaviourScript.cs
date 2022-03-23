using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatasWrap;
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void select()
    {
        
        
        ItemDatasWrap itemDatasWrap = ItemSaveJsonScript.ItemDataWrapped();
        string jsonstr2 = JsonUtility.ToJson(itemDataWrap);
        Debug.Log(jsonstr2);
    }
}
