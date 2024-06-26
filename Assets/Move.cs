using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private new Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 移動量
        Vector3 moveVec = new(1, 0, 0);

        // 物理挙動
        rigidbody.AddForce(moveVec);

        // 座標移動
        transform.position += moveVec;
    }
}
