using UnityEngine;
using UnityEngine.UI;

public class AI : MonoBehaviour
{
    public Image player;
    public float speed;
    public bool isEnd = false;
    public Text speedText;
    public Text xText;
    public Text yText;

    void Update()
    {
        if (!isEnd)
        {
            Vector2 playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
            Vector2 AIposSame = new Vector2(transform.position.x, transform.position.y);

            if (playerPos.x > transform.position.x)
            {
                Vector2 AIpos = new Vector2(transform.position.x + speed, transform.position.y);
                transform.position = AIpos;
            }
            else if (playerPos.x < transform.position.x)
            {
                Vector2 AIpos = new Vector2(transform.position.x - speed, transform.position.y);
                transform.position = AIpos;
            }

            if (playerPos.y > transform.position.y)
            {
                Vector2 AIpos = new Vector2(transform.position.x, transform.position.y + speed);
                transform.position = AIpos;
            }
            else
            {
                Vector2 AIpos = new Vector2(transform.position.x, transform.position.y - speed);
                transform.position = AIpos;
            }

            speed += 0.0001f;
            speedText.text = (speed * 10).ToString();
            xText.text = Mathf.Abs(playerPos.x - AIposSame.x).ToString();
            yText.text = Mathf.Abs(playerPos.y - AIposSame.y).ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isEnd = true;
    }
}