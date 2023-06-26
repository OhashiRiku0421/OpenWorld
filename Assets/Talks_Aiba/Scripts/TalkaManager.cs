using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class TalkaManager : MonoBehaviour
{
    [Header("��b�̓��e�̃X�N���^�u���I�u�W�F�N�g")]
    [SerializeField] private TalkData _talkData;

    [Header("�J�n���ɍs����������")]
    [SerializeField] private UnityEvent _startTalk;

    [Header("�I�����ɍs����������")]
    [SerializeField] private UnityEvent _endTalk;

    [Header("�b��UI")]
    [SerializeField] private GameObject _talkPanel;

    [Header("�b����̖��O")]
    [SerializeField] private Text _nameText;

    [Header("��b��Text")]
    [SerializeField] private Text _talkText;

    [Header("��b�\�A�V�X�g")]
    [SerializeField] private GameObject _talkAssist;

    [SerializeField]
    private GameObject _talker;

    private Collider _collider;



    private List<string> _talk = new List<string>();

    private bool _isEnter = false;

    private bool _isTalkNow = false;
    public bool IsEnter { get => _isEnter; set => _isEnter = value; }
    public Collider Collider { get => _collider; set => _collider = value; }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_isTalkNow && _isEnter)
        {
            StartTalk();
        }
    }

    private void FixedUpdate()
    {
        if(_collider!=null)
        {
            _talker.transform.forward = _collider.gameObject.transform.position;
        }
    }

    /// <summary>
    /// ��b���n�߂�
    /// </summary>
    public void StartTalk()
    {
        //�J�n���ɌĂт����������Ă�
        _startTalk?.Invoke();

        //��b�̃p�l����\���B
        _talkPanel.SetActive(true);

        _isTalkNow = true;

        StartCoroutine(Talk());

        SetAssistPanel(false);
    }

    /// <summary>
    /// ��b�̏���
    /// </summary>
    /// <returns></returns>
    IEnumerator Talk()
    {
        //�~�b�V�����̎�t��Ԃɂ���āA��b�̓��e��ς���

        _nameText.text = _talkData.HumanName;

        List<string> talk = new List<string>();
        talk = _talkData.DataTalk;

        //�b���Ă���e�L�X�g���X�V�B
        for (int i = 0; i < talk.Count; i++)
        {
            //�e�L�X�g���X�V
            _talkText.text = talk[i];
            yield return null;
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
            yield return null;
        }

        yield return new WaitForSeconds(0.2f);

        //��b�̃p�l�������
        EndTalk();
        StopCoroutine(Talk());
    }
    public void EndTalk()
    {

        //�I������
        _endTalk?.Invoke();

        //��b�̃p�l�����\���ɂ���
        _talkPanel.SetActive(false);

        _isTalkNow = false;
        _isEnter = false;
    }


    public void SetAssistPanel(bool isOn)
    {
        _talkAssist.SetActive(isOn);
    }

}
