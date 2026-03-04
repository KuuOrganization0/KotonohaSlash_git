using TMPro;
using UnityEngine;

public class BantukeController : MonoBehaviour
{
    TMP_Text TextMeshPro; //TextMeshProはTMP_Textを継承している派生先なので、TMP_Textを使う
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextMeshPro = GetComponent<TMP_Text>();
            if (LevelHold.levelspeed == 0.4f)
            {
                TextMeshPro.text = "番付(初級)";
            }
            else if (LevelHold.levelspeed == 0.7f)
            {
                TextMeshPro.text = "番付(中級)";
            }
            else if (LevelHold.levelspeed == 1f)
            {
                TextMeshPro.text = "番付(上級)";
        }
    }

    // Update is called once per frame
 
    
}
