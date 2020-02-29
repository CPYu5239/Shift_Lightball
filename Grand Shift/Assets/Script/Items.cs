using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    Text puzzleText;

    private void Start()
    {
        puzzleText = GameObject.Find("拼圖數量").GetComponent<Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "玩家" && this.tag == "電池")
        {
            Destroy(gameObject);
            GameManager.player.GetComponent<Player>().data.battery = GameManager.player.GetComponent<Player>().data.maxBattery;
        }

        if (collision.gameObject.tag == "玩家" && this.tag == "補血")
        {
            Destroy(gameObject);
            GameManager.player.GetComponent<Player>().data.hp = GameManager.player.GetComponent<Player>().data.maxHp;
        }

        if (collision.gameObject.tag == "玩家" && this.tag == "記憶拼圖")
        {
            int text = int.Parse(puzzleText.text);
            text++;
            puzzleText.text = text.ToString();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "玩家" && this.tag == "電池")
        {
            Destroy(gameObject);
            GameManager.player.GetComponent<Player>().data.battery = GameManager.player.GetComponent<Player>().data.maxBattery;
        }

        if (other.gameObject.tag == "玩家" && this.tag == "補血")
        {
            Destroy(gameObject);
            GameManager.player.GetComponent<Player>().data.hp = GameManager.player.GetComponent<Player>().data.maxHp;
        }

        if (other.gameObject.tag == "玩家" && this.tag == "記憶拼圖")
        {
            int text = int.Parse(puzzleText.text);
            text++;
            puzzleText.text = text.ToString();
            Destroy(gameObject);
        }
    }
}