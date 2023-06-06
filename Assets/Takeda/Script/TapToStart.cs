using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TapToStart : MonoBehaviour
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

    public static int getRoot()
    {
        return Root;
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
        // �V�[���̓ǂݍ��݂�����
        async = SceneManager.LoadSceneAsync("Load1");

        //�@�ǂݍ��݂��I���܂Ői���󋵂��X���C�_�[�̒l�ɔ��f������
        while (!async.isDone)
        {
            var progressVal = Mathf.Clamp01(async.progress / 0.9f);
            slider.value = progressVal;
            yield return null;
        }
    }

    //IEnumerator Color_FadeIn()
    //{
    //    // ��ʂ��t�F�[�h�C��������R�[���`��
    //    // �O��F��ʂ𕢂�Panel�ɃA�^�b�`���Ă���

    //    // �F��ς���Q�[���I�u�W�F�N�g����Image�R���|�[�l���g���擾
    //    Image fade = GetComponent<Image>();

    //    // �t�F�[�h���̐F��ݒ�i���j���ύX��
    //    fade.color = new Color((0.0f / 255.0f), (0.0f / 255.0f), (0.0f / 0.0f), (255.0f / 255.0f));

    //    // �t�F�[�h�C���ɂ����鎞�ԁi�b�j���ύX��
    //    const float fade_time = 2.0f;

    //    // ���[�v�񐔁i0�̓G���[�j���ύX��
    //    const int loop_count = 90;

    //    // �E�F�C�g���ԎZ�o
    //    float wait_time = fade_time / loop_count;

    //    // �F�̊Ԋu���Z�o
    //    float alpha_interval = 255.0f / loop_count;

    //    // �F�����X�ɕς��郋�[�v
    //    for (float alpha = 255.0f; alpha >= 0.0f; alpha -= alpha_interval)
    //    {
    //        // �҂�����
    //        yield return new WaitForSeconds(wait_time);

    //        // Alpha�l��������������
    //        Color new_color = fade.color;
    //        new_color.a = alpha / 255.0f;
    //        fade.color = new_color;
    //    }
    //}
}
