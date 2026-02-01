using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer spr = GetComponent<SpriteRenderer>();
        float width = spr.sprite.bounds.size.x;
        float height = spr.sprite.bounds.size.y;

        float worldScreenHeight = Camera.main.orthographicSize * 2f;
        float worldScreenWidth = worldScreenHeight * Screen.width / Screen.height;

        transform.localScale = new Vector3(
            worldScreenWidth / width,
            worldScreenHeight / height,
            1);

    }

    // Update is called once per frame
  
}
