using TMPro;
using UnityEngine;


public class CountController : MonoBehaviour
{
    TMP_Text TextMeshPro; //TextMeshPro‚ÍTMP_Text‚ğŒp³‚µ‚Ä‚¢‚é”h¶æ‚È‚Ì‚ÅATMP_Text‚ğg‚¤
    public GameObject Player;
    PlayerController PlayerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextMeshPro = GetComponent<TMP_Text>();
        PlayerController = Player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        int PlasCount = PlayerController.PlasCount * -500;
        int MinasCount = PlayerController.MinasCount * 1000;

        int TextScore = PlasCount + MinasCount;
        TextMeshPro.text = TextScore.ToString();

    }
}
