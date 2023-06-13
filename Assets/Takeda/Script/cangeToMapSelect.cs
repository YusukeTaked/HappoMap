using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cangeToMapSelect : MonoBehaviour
{
    public GameObject Panelfade;   //�t�F�[�h�p�l���̎擾

    Image fadealpha;               //�t�F�[�h�p�l���̃C���[�W�擾�ϐ�

    private float alpha;           //�p�l����alpha�l�擾�ϐ�

    public static int Root;

    private bool fadeActive = false;

    //�@�񓯊�����Ŏg�p����AsyncOperation
    private AsyncOperation async;
    //�@�V�[�����[�h���ɕ\������UI���
    [SerializeField]
    private GameObject loadUI;
    //�@�ǂݍ��ݗ���\������X���C�_�[
    [SerializeField]
    private Slider slider;

    public void NextScene()
    {
        //�@���[�h���UI���A�N�e�B�u�ɂ���
        loadUI.SetActive(true);

        //�@�R���[�`�����J�n
        StartCoroutine("LoadData");
    }


    // Start is called before the first frame update
    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>(); //�p�l���̃C���[�W�擾
        alpha = fadealpha.color.a;                 //�p�l����alpha�l���擾
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
        // �V�[���̓ǂݍ��݂�����
        async = SceneManager.LoadSceneAsync("MapSelect");

        //�@�ǂݍ��݂��I���܂Ői���󋵂��X���C�_�[�̒l�ɔ��f������
        while (!async.isDone)
        {
            var progressVal = Mathf.Clamp01(async.progress / 0.9f);
            slider.value = progressVal;
            yield return null;
        }
    }

}
