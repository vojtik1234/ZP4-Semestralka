using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;

    private float moveX;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToMainMenu();
        }

        // Zkontrolujte, zda je panáèek pod hranicí viditelné oblasti kamery
        Vector3 cameraPosition = Camera.main.transform.position;
        if (transform.position.y < cameraPosition.y - 5f)
        {
            ReturnToMainMenu();
        }
    }

    // Funkce pro návrat do hlavního menu
    private void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }
}
