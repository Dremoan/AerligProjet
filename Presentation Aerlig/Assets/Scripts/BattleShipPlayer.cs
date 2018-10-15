using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleShipPlayer : MonoBehaviour {

    [Range(0.01f,0.05f)]
    [SerializeField] float speed = 1f;
    public GameObject bulletPrefab;
    public Transform canon1;
    private bool canShoot = true;
    [SerializeField] float reloadTime = 0.25f;

	void Update ()
    {
        Move();

        if (Input.GetKey(KeyCode.Space) && canShoot)
        {
            StartCoroutine(Reloading());
            Instantiate(bulletPrefab, canon1.position, canon1.rotation);
        }
    }

    void Move()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.position += Vector3.forward * speed * horizontal;
        transform.position += Vector3.left * speed * vertical;
    }

    IEnumerator Reloading()
    {
        canShoot = false;
        yield return new WaitForSeconds(reloadTime);
        canShoot = true;
    }
}
