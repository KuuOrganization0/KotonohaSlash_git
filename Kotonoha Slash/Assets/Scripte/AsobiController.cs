using UnityEngine;

public class AsobiController : MonoBehaviour
{
    public GameObject AsobiPrefab; // 遊び方の説明のプレハブ
    Quaternion rotate = Quaternion.identity;　//回転なし

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AsobiGenerate()
    {
        Instantiate(AsobiPrefab, new Vector3(0, 0, 0), rotate);
    }
    // Update is called once per frame
    public void DeleteAsobi()
    {
        Destroy(AsobiPrefab);
    }
}
