using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Title : MonoBehaviour
{
    Image cross;
    private void Start()
    {
        cross = GameObject.Find("轉場畫面").GetComponent<Image>();
    }

    public void LoadScene()
    {
        StartCoroutine(ChangeScene());
    }

    private IEnumerator ChangeScene()
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync("新手教學場景");

        ao.allowSceneActivation = false;                                // 載入場景資訊.是否允許切換 = 否
        while (!ao.isDone)                                              // 當(載入場景資訊.是否完成 為 否)
        {
            print(ao.progress);
            cross.color = new Color(1, 1, 1, ao.progress);              // 轉場畫面.顏色 = 新 顏色(1，1，1，透明度) // ao.progress 載入進度 0 - 0.9
            yield return new WaitForSeconds(0.01f);

            if (ao.progress >= 0.9f) ao.allowSceneActivation = true;    // 當 載入進度 >= 0.9 允許切換
        }
    }
}
