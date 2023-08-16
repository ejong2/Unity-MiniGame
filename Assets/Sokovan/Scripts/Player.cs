using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager; // ���� �Ŵ���

    // �÷��̾��� �̵� �ӵ�
    public float speed = 10f;

    // �÷��̾��� ������ٵ� ������Ʈ
    Rigidbody playerRigidbody;

    // ������ ���۵� �� �� ���� ȣ��Ǵ� �Լ� -> �ʱ�ȭ
    void Start()
    {
        // GetComponent<Ÿ��>() : Ÿ�Կ� �ش��ϴ� ������Ʈ�� ã�Ƽ� ��ȯ
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // �� �����Ӹ��� ȣ��Ǵ� �Լ� -> ���� �Է��� �޾Ƽ� ó��
    void Update()
    {
        if (gameManager.isGameover) return; // ���� ���� ���¶�� ������Ʈ�� �������� ����

        // GetAxis() : Ű���� �Է��� �޾Ƽ� -1 ~ 1 ������ ���� ��ȯ
        float inpuitX = Input.GetAxis("Horizontal"); // ���̽�ƽ ���� ����
        float inputZ = Input.GetAxis("Vertical"); 
        float fallSpeed = playerRigidbody.velocity.y; // �߷¿� ���� �������� �ӵ��� ������Ű�� ����

        // ���� * �ӵ� = �ӵ� ����
        Vector3 velocity = new Vector3(inpuitX, 0f, inputZ);

        velocity = velocity * speed; // ���� * �ӵ�
        velocity.y = fallSpeed; // �߷¿� ���� �������� �ӵ��� ������Ű�� ����

        // ������ٵ��� �ӵ��� velocity�� ����
        playerRigidbody.velocity = velocity;
    }
}
