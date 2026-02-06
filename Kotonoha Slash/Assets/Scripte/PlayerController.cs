using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionAsset action ;//アクションのアセット
    private InputAction clickAction;//アセットの中のアクションを代入するための変数
    WordController change = null;
    public static int PlasCount;
    public static int MinasCount;
    AudioSource audioSource;
    Collider2D hit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlasCount = 0;
        MinasCount = 0;
        var map = action.FindActionMap("Player"); // ActionMap名
        clickAction = map.FindAction("Left Click");     // Action名
        clickAction.Enable();//アクションを有効化
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Application.isMobilePlatform)
        { //スマホの場合
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                //タッチで（スクリーン座標 → ワールド座標）
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(touch.position);

                hit = Physics2D.OverlapPoint(mousePos);

                if(touch.phase == UnityEngine.TouchPhase.Ended)
                {
                    hit = null;
                }
            }
        }
        else
        { //パソコンの場合
            if (clickAction.IsPressed())
            {

                // 新InputSystemでマウス位置を取得（スクリーン座標 → ワールド座標）
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

                hit = Physics2D.OverlapPoint(mousePos);

            }
        }



                // Raycast判定
                if (hit != null && hit.tag == "PlasWord") //2Dを忘れないようにする,その場のコライダーを判定
                {
                    change = hit.gameObject.GetComponent<WordController>();
                    if (change != null)
                    {
                        SEController.seController.CallSE(2);
                        change.Change();
                        PlasCount++;
                    }
                }
                else if (hit != null && hit.tag == "MinasWord")
                {
                    change = hit.gameObject.GetComponent<WordController>();
                    if (change != null)
                    {
                SEController.seController.CallSE(1);
                change.Change();
                        MinasCount++;
                    }
                }

            
        
    }
}
