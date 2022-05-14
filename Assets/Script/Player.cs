using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    //�ړ��X�e
    private float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        //�ړ��L�[
        if (Input.GetKey("a"))
        {
            position.x -= speed;
        }
        else if (Input.GetKey("d"))
        {
            position.x += speed;
        }
        if (Input.GetKey("w"))
        {
            position.y += speed;
        }
        if (Input.GetKey("s"))
        {
            position.y -= speed;
        }

        transform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ���̂��g���K�[�ɐڐG���Ƃ��A�P�x�����Ă΂��
        Debug.Log("b");
        //�ڐG�����I�u�W�F�N�g�̃^�O��"Orb"�̂Ƃ�
        if (collision.gameObject.tag == ("Item"))
        {
            Debug.Log("�A�C�e���Q�b�g�I");
        }
    }
}
