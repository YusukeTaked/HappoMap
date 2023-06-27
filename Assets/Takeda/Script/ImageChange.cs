using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageChange : MonoBehaviour
{
    /// <summary>�摜��ύX����X�v���C�g�I�u�W�F�N�g�B</summary>
    [SerializeField] private GameObject TargetSprite;

    /// <summary>�ύX��̉摜�����X�v���C�g�B</summary>
    [SerializeField] private Sprite NextSprite;

    [SerializeField] private Sprite ScNextSprite;
    private int turn = 0;

    public GameObject TargetIcon;

    // Start is called before the first frame update
    void Start()
    {
        TargetIcon.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTap()
    {
        var spriteRenderer = TargetSprite.GetComponent<Image>();
        if (turn == 0)
        {
            spriteRenderer.sprite = NextSprite;
            turn = 1;
            TargetIcon.SetActive(true);
        }
        else
        {
            spriteRenderer.sprite = ScNextSprite;
            turn = 0;
            TargetIcon.SetActive(false);
        }
    }
}
