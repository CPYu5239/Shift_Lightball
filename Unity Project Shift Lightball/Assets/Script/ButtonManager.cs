using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    #region 宣告
    Animator ani1;
    Animator ani2;
    Animator ani3;
    Animator ani4;
    Animator ani5;
    Animator ani6;
    Animator ani7;
    Animator ani8;
    Animator ani9;
    Animator ani10;
    Animator ani11;
    Animator ani12;
    Animator ani13;
    Animator ani14;
    Animator ani15;
    public GameObject settingMenu;
    #endregion

    private void Start()
    {
        ani1 = GameObject.Find("移動方向教學").GetComponent<Animator>();
        ani2 = GameObject.Find("移動方向教學2").GetComponent<Animator>();
        ani3 = GameObject.Find("變身教學").GetComponent<Animator>();
        ani4 = GameObject.Find("變身教學2").GetComponent<Animator>();
        ani5 = GameObject.Find("變身教學3").GetComponent<Animator>();
        ani6 = GameObject.Find("變身教學4").GetComponent<Animator>();
        ani7 = GameObject.Find("攻擊教學").GetComponent<Animator>();
        ani8 = GameObject.Find("攻擊教學2").GetComponent<Animator>();
        ani9 = GameObject.Find("切換維度教學").GetComponent<Animator>();
        ani10 = GameObject.Find("切換維度教學2").GetComponent<Animator>();
        ani11 = GameObject.Find("切換維度教學3").GetComponent<Animator>();
        ani12 = GameObject.Find("切換維度教學4").GetComponent<Animator>();
        ani13 = GameObject.Find("道具介紹").GetComponent<Animator>();
        ani14 = GameObject.Find("道具介紹2").GetComponent<Animator>();
        ani15 = GameObject.Find("空氣牆").GetComponent<Animator>();
    }

    #region 移動方向教學
    public void OpenBasicMovement()
    {
        ani1.SetTrigger("移動方向教學(淡入)");
    }

    public void ShowBasicMovement()
    {
        ani1.SetTrigger("移動方向教學(淡入)");
        ani2.SetTrigger("移動方向教學2(淡出)");
    }

    public void ShowBasicMovement2()
    {
        ani1.SetTrigger("移動方向教學(淡出)");
        ani2.SetTrigger("移動方向教學2(淡入)");
    }

    public void CloseBasicMovement2()
    {

        ani2.SetTrigger("移動方向教學2(淡出)");

    }
    #endregion

    #region  變身教學
    public void OpenTransform()
    {
        ani3.SetTrigger("變身教學(淡入)");
    }

    public void ShowTransform()
    {
        ani3.SetTrigger("變身教學(淡入)");
        ani4.SetTrigger("變身教學2(淡出)");
    }

    public void ShowTransform2()
    {
        ani3.SetTrigger("變身教學(淡出)");
        ani4.SetTrigger("變身教學2(淡入)");
    }

    public void ShowTransform32()
    {
        ani4.SetTrigger("變身教學2(淡入)");
        ani5.SetTrigger("變身教學3(淡出)");
    }

    public void ShowTransform3()
    {
        ani4.SetTrigger("變身教學2(淡出)");
        ani5.SetTrigger("變身教學3(淡入)");
    }

    public void ShowTransform43()
    {
        ani5.SetTrigger("變身教學3(淡入)");
        ani6.SetTrigger("變身教學4(淡出)");
    }

    public void ShowTransform4()
    {
        ani5.SetTrigger("變身教學3(淡出)");
        ani6.SetTrigger("變身教學4(淡入)");
    }

    public void CloseTransform4()
    {
        ani6.SetTrigger("變身教學4(淡出)");
    }
    #endregion

    #region  攻擊教學
    public void OpenAttack()
    {
        ani7.SetTrigger("攻擊教學(淡入)");
    }

    public void ShowAttack()
    {
        ani7.SetTrigger("攻擊教學(淡入)");
        ani8.SetTrigger("攻擊教學2(淡出)");
    }

    public void ShowAttack2()
    {
        ani7.SetTrigger("攻擊教學(淡出)");
        ani8.SetTrigger("攻擊教學2(淡入)");
    }

    public void CloseAttack2()
    {
        ani8.SetTrigger("攻擊教學2(淡出)");
    }
    #endregion

    #region 切換維度教學
    public void Open3DMode()
    {
        ani9.SetTrigger("切換維度教學(淡入)");
    }

    public void Show3DMode()
    {
        ani9.SetTrigger("切換維度教學(淡入)");
        ani10.SetTrigger("切換維度教學2(淡出)");
    }

    public void Show3DMode2()
    {
        ani9.SetTrigger("切換維度教學(淡出)");
        ani10.SetTrigger("切換維度教學2(淡入)");
    }

    public void Show3DMode32()
    {
        ani10.SetTrigger("切換維度教學2(淡入)");
        ani11.SetTrigger("切換維度教學3(淡出)");
    }

    public void Show3DMode3()
    {
        ani10.SetTrigger("切換維度教學2(淡出)");
        ani11.SetTrigger("切換維度教學3(淡入)");
    }

    public void Show3DMode43()
    {
        ani11.SetTrigger("切換維度教學3(淡入)");
        ani12.SetTrigger("切換維度教學4(淡出)");
    }

    public void Show3DMode4()
    {
        ani11.SetTrigger("切換維度教學3(淡出)");
        ani12.SetTrigger("切換維度教學4(淡入)");
    }

    public void Close3DMode4()
    {
        ani12.SetTrigger("切換維度教學4(淡出)");
    }
    #endregion

    #region  道具介紹
    public void OpenProp()
    {
        ani13.SetTrigger("道具介紹(淡入)");
    }

    public void ShowProp()
    {
        ani13.SetTrigger("道具介紹(淡入)");
        ani14.SetTrigger("道具介紹2(淡出)");
    }

    public void ShowProp2()
    {
        ani13.SetTrigger("道具介紹(淡出)");
        ani14.SetTrigger("道具介紹2(淡入)");
    }

    public void CloseProp2()
    {
        ani14.SetTrigger("道具介紹2(淡出)");
    }

    public void OpenTheAirWall()
    {
        ani15.SetTrigger("空氣牆(淡入)");
    }

    public void CloseTheAirWall()
    {
        ani15.SetTrigger("空氣牆(淡出)");
    }
    #endregion

    /// <summary>
    /// 開啟遊戲設定介面
    /// </summary>
    public void OpenSetting()
    {
        settingMenu.SetActive(true);
    }

    /// <summary>
    /// 關閉遊戲設定介面
    /// </summary>
    public void CloseSetting()
    {
        settingMenu.SetActive(false);
    }
}