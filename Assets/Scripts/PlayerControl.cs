using UnityEngine;
using Mirror;

public class PlayerControl : NetworkBehaviour
{
    [SerializeField] 
    private Player player;
    void Start()
    {
        player = GetComponent<Player>();
        transform.position = new Vector3(transform.position.x, 10 , transform.position.z);
    }
    // ����X�V���ɌĂ΂��
    void FixedUpdate()
    {
        // ���[�J���v���C���[�̎�
        if (isLocalPlayer)
        {
            // ����
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            CmdMoveSphere(x, z);
        }
    }

    // ���̈ړ�
    [Command]
    void CmdMoveSphere(float x, float z)
    {
        Vector3 v = new Vector3(x, 0, z) * 5f;
        GetComponent<Rigidbody>().AddForce(v);
    }
}