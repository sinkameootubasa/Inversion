using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        // ���̂��A�C�e���ɐڐG�����Ƃ��A��x�����Ă΂��
        Debug.Log("b");
        // �ڐG�����̂��v���C���[�̏ꍇ
        if (collider.gameObject.tag == ("Player"))
        {
            Destroy(this.gameObject);   
        }

    }
}
