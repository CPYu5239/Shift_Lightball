using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{

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
            Destroy(gameObject);

        }


    }
    }

