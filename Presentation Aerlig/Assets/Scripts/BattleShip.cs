using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleShip : MonoBehaviour {

    [Range(1f,5f)]
    [SerializeField] float speed = 1f;
    [SerializeField] Transform targetShip;
    public GameObject bulletPrefab;
    public Transform canon1;
    private bool canShoot = true;
    public bool isPlayer;
    [SerializeField] float reloadTime = 0.25f;

	void Update ()
    {
        Move();
        Shoot();
        
    }

    void Shoot()
    {
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

        if(!isPlayer)
        {
            if(transform.position.x - targetShip.transform.position.x < 0)
            {
                transform.position -= new Vector3(1, 0, 0) * speed;
            }
            else
            {
                transform.position += new Vector3(1, 0, 0) * speed;
            }
        }
    }

    IEnumerator Reloading()
    {
        canShoot = false;
        yield return new WaitForSeconds(reloadTime);
        canShoot = true;
    }
}
