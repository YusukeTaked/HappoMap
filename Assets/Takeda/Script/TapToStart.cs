using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TapToStart : MonoBehaviour
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

    public static int getRoot()
    {
        return Root;
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
        if (fadeActive)
        {
            if (alpha >= 255)
            {
                if (Root == 1)
                {
                    SceneManager.LoadScene("");
                }
            }
        }
    }
    public void ChangeARoot()
    {
        Panelfade.SetActive(true);
        fadeActive = true;
        Root = 1;
    }
    IEnumerator LoadData()
    {
        // シーンの読み込みをする
        async = SceneManager.LoadSceneAsync("Load1");

        //　読み込みが終わるまで進捗状況をスライダーの値に反映させる
        while (!async.isDone)
        {
            var progressVal = Mathf.Clamp01(async.progress / 0.9f);
            slider.value = progressVal;
            yield return null;
        }
    }

    //IEnumerator Color_FadeIn()
    //{
    //    // 画面をフェードインさせるコールチン
    //    // 前提：画面を覆うPanelにアタッチしている

    //    // 色を変えるゲームオブジェクトからImageコンポーネントを取得
    //    Image fade = GetComponent<Image>();

    //    // フェード元の色を設定（黒）★変更可
    //    fade.color = new Color((0.0f / 255.0f), (0.0f / 255.0f), (0.0f / 0.0f), (255.0f / 255.0f));

    //    // フェードインにかかる時間（秒）★変更可
    //    const float fade_time = 2.0f;

    //    // ループ回数（0はエラー）★変更可
    //    const int loop_count = 90;

    //    // ウェイト時間算出
    //    float wait_time = fade_time / loop_count;

    //    // 色の間隔を算出
    //    float alpha_interval = 255.0f / loop_count;

    //    // 色を徐々に変えるループ
    //    for (float alpha = 255.0f; alpha >= 0.0f; alpha -= alpha_interval)
    //    {
    //        // 待ち時間
    //        yield return new WaitForSeconds(wait_time);

    //        // Alpha値を少しずつ下げる
    //        Color new_color = fade.color;
    //        new_color.a = alpha / 255.0f;
    //        fade.color = new_color;
    //    }
    //}
}
