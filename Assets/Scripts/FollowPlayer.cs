using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform PlayerTranform;
    [SerializeField] float XOffset = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PlayerTranform.position.x + XOffset, transform.position.y, transform.position.z);
    }
}
