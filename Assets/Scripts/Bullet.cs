using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("weeeeeeee");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * bulletSpeed * Time.deltaTime);
    }
}
