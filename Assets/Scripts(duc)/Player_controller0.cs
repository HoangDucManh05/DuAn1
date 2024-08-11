using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_controller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    private Vector3 targetPosition;
    private bool isMoving = false;
    public int HP = 5;
    public TextMeshProUGUI HPText;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        HPText.SetText(HP.ToString());
    }

    void Update()
    {
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector2 huongNhin = mousePos - transform.position;

        //float gocXoay = Mathf.Atan2(huongNhin.y, huongNhin.x) * Mathf.Rad2Deg - 90;
        //rb.rotation = gocXoay;

        
        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0;
            isMoving = true;

            Vector3 direction = targetPosition - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle - 90;
        }
        if (isMoving)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                isMoving = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            HP--;
            HPText.SetText(HP.ToString());
            if (HP == 0)
            {
                SceneManager.LoadScene("Game over(duc)");
            }
        }
    }
}
