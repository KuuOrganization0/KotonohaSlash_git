using System;
using UnityEngine;
using UnityEngine.UIElements;

public class SettingGenerator : MonoBehaviour
{
    public GameObject settingPrefab; // 設定画面のプレハブ
    public GameObject settingGeneratorPrefab; // 設定画面のボタン
    Quaternion rotate = Quaternion.identity;　//回転なし

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SettingGenerate()
    {
        Instantiate(settingPrefab,new Vector3(0,0,0), rotate);
    }
    public void SettingGeneratorGenerate()
    {
        Instantiate(settingGeneratorPrefab, new Vector3(0, 0, 0), rotate);
    }
    // Update is called once per frame
    public void DeleteSetting()
    {
        Destroy(settingPrefab);
    }
    public void DeleteSettingGenerator()
    {
        Destroy(settingGeneratorPrefab);
    }
}
