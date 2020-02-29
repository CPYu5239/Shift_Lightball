using UnityEngine.UI;
using UnityEngine;

public class BarControler : MonoBehaviour
{
    public Image imgHp;        // 血條
    public Image imgBattery;   // 電量條
    public Image imgEnergy;    // 能量條

    /// <summary>
    /// 更新血條圖片長度
    /// </summary>
    /// <param name="hpMax"></param>
    /// <param name="hpCurrent"></param>
    public void UpdateHpBar(float hpMax, float hpCurrent)
    {
        imgHp.fillAmount = hpCurrent / hpMax;  //圖片.填滿數值 = 目前血量/最大血量
    }

    /// <summary>
    /// 更新電量條圖片長度
    /// </summary>
    /// <param name="batteryMax"></param>
    /// <param name="batteryCurrent"></param>
    public void UpdateBatteryBar(float batteryMax, float batteryCurrent)
    {
        imgBattery.fillAmount = batteryCurrent / batteryMax;  //圖片.填滿數值 = 目前電量/最大電量
    }

    /// <summary>
    /// 更新能量條圖片長度
    /// </summary>
    /// <param name="energyMax"></param>
    /// <param name="energyCurrent"></param>
    public void UpdateEnergyBar(float energyMax, float energyCurrent)
    {
        imgEnergy.fillAmount = energyCurrent / energyMax;  //圖片.填滿數值 = 目前能量/最大能量
    }
}