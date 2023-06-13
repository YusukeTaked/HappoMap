using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cangeToMapSelect : MonoBehaviour
{
    public GameObject Panelfade;   //フェードパネルの取得

    Image fadealpha;               //フェードパネルのイメージ取得変数

    private float alpha;           //パネルのalpha値取得変数

    public static int Root;

    private bool fadeActive = false;

    //　非同期動作で使用するAsyncOperation
    private AsyncOperation async;
    //　シーンロード中に表示するUI画面
    [SerializeField]
    private GameObject loadUI;
    //　読み込み率を表示するスライダー
    [SerializeField]
    private Slider slider;

    public void NextScene()
    {
        //　ロード画面UIをアクティブにする
        loadUI.SetActive(true);

        //　コルーチンを開始
        StartCoroutine("LoadData");
    }


    // Start is called before the first frame update
    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>(); //パネルのイメージ取得
        alpha = fadealpha.color.a;                 //パネルのalpha値を取得
        Panelfade.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (fadeActive == true)
        {
            if (alpha < 1)
            {
                alpha += 0.1f;
                fadealpha.color = new Color(0, 0, 0, alpha);

            }
            else if (alpha >= 1)
            {
                NextScene();
                fadeActive = false;
            }
        }
        }
    

    public void OnTap()
    {
        Panelfade.SetActive(true);
        fadeActive = true;
        Root = 1;
        fadeActive = true;
    }
    IEnumerator LoadData()
    {
        // シーンの読み込みをする
        async = SceneManager.LoadSceneAsync("MapSelect");

        //　読み込みが終わるまで進捗状況をスライダーの値に反映させる
        while (!async.isDone)
        {
            var progressVal = Mathf.Clamp01(async.progress / 0.9f);
            slider.value = progressVal;
            yield return null;
        }
    }

}
