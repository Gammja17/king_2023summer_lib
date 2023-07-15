using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public GameObject Cam;
    public CharacterController SelectPlayer;
    public float Speed;
    private float Gravity;
    private Vector3 MoveDir;

    void Start()
    {
        Speed = 5.0f;
        Gravity = 10.0f;
        MoveDir = Vector3.zero;
    }

    void Update()
    {
        if (SelectPlayer == null) return;



        if (SelectPlayer.isGrounded)//�����پ�������, �߶��ϴ� �߿��� �̵�X
        {

            MoveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // Ű���忡 ���� X, Z �� �̵������� ���� ����
            MoveDir = SelectPlayer.transform.TransformDirection(MoveDir); // ������Ʈ�� �ٶ󺸴� �չ������� �̵������� ������ ����
            MoveDir *= Speed; // �ӵ��� ���ؼ� ����
        }
        else   //����̸�
        {
            MoveDir.y -= Gravity * Time.deltaTime;//�߷��� ����, �Ʒ��� �ϰ�
        }
        SelectPlayer.Move(MoveDir * Time.deltaTime); //���� �̵� ó��
    }

}