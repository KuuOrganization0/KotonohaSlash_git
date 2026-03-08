using System;
using UnityEngine;
using UnityEngine.UIElements;

public class SettingGenerator : MonoBehaviour
{
    public GameObject settingPrefab; // 設定画面のプレハブ
    Quaternion rotate = Quaternion.identity;　//回転なし

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SettingGenerate()
    {
        Instantiate(settingPrefab,new Vector3(0,0,0), rotate);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
