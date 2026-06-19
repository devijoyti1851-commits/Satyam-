using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public Camera playerCamera;
    public float damage = 25f;

    void Update()
    {
        // प्लेयर का मूवमेंट (Movement)
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(moveX, 0, moveZ);

        // शूटिंग और शॉट डिटेक्शन (Shooting & Shot Detection)
        if (Input.GetButtonDown("Fire1"))
        {
            ShootWeapon();
        }
    }

    void ShootWeapon()
    {
        RaycastHit hit;
        // कैमरे के बीच से एक अदृश्य किरण (Ray) निकलेगी
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit))
        {
            // अगर दुश्मन के सिर (Head) पर गोली लगी
            if (hit.collider.CompareTag("Head"))
            {
                Debug.Log("HEADSHOT! Double Damage!");
                hit.collider.GetComponent<EnemyHealth>().TakeDamage(damage * 2);
            }
            // अगर दुश्मन के शरीर (Body) पर गोली लगी
            else if (hit.collider.CompareTag("EnemyBody"))
            {
                Debug.Log("Body Shot!");
                hit.collider.GetComponent<EnemyHealth>().TakeDamage(damage);
            }
        }
    }
}
