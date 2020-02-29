using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    ButtonManager buttonManager;
    bool istriggerMovement;
    bool istriggerTransform;
    bool istriggerAttack;
    bool istrigger3DMode;
    bool istriggerProp;
    bool istriggerAirWall;

    private void Start()
    {
        buttonManager = GameObject.Find("按鈕管理器").GetComponent<ButtonManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "玩家")
        {
            switch (gameObject.name)
            {
                case "移動方向教學感應區":
                    if (!istriggerMovement)
                    {
                        buttonManager.OpenBasicMovement();
                        istriggerMovement = true;
                        gameObject.SetActive(false);
                    }
                    break;
                case "變身教學感應區":
                    if (!istriggerTransform)
                    {
                        buttonManager.OpenTransform();
                        istriggerTransform = true;
                        gameObject.SetActive(false);
                    }
                    break;
                case "攻擊教學感應區":
                    if (!istriggerAttack)
                    {
                        buttonManager.OpenAttack();
                        istriggerAttack = true;
                        gameObject.SetActive(false);
                    }
                    break;
                case "切換維度教學感應區":
                    if (!istrigger3DMode)
                    {
                        buttonManager.Open3DMode();
                        istrigger3DMode = true;
                        gameObject.SetActive(false);
                    }
                    break;
                case "道具介紹感應區":
                    if (!istriggerProp)
                    {
                        buttonManager.OpenProp();
                        istriggerProp = true;
                        gameObject.SetActive(false);
                    }
                    break;
                case "空氣牆感應區":
                    if (!istriggerAirWall)
                    {
                        buttonManager.OpenTheAirWall();
                        istriggerAirWall = true;
                        gameObject.SetActive(false);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}