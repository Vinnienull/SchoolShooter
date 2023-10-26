using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{

    [SerializeField] float speed;
    private int ammo;
    [SerializeField] int maxAmmo;

    [SerializeField] GameObject bullet;
    [SerializeField] Text ammoText;

    // Start is called before the first frame update
    void Start()
    {
        ammo = maxAmmo;
        ammoText.text = "Ammo Count = " + maxAmmo + "/" + maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        //movement controls
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        //shooting controls
        if (Input.GetKeyDown(KeyCode.Space) && ammo > 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            ammo -= 1;
            ammoText.text = "Ammo Count = " + ammo + "/" + maxAmmo;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ammo = maxAmmo;
            ammoText.text = "Ammo Count = " + ammo + "/" + maxAmmo;
        }
    }
}
