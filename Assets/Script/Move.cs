using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    bool isStop = false;
    public float moveSpeed = 5f; // 移動速度


    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //TODO
        //移動せよ
        //https://candle-stoplight-544.notion.site/4e021f226d584730b715626436ccc330

        _rigidBody.MovePosition(_rigidBody.position + transform.right * moveSpeed * Time.fixedDeltaTime);
    }
}