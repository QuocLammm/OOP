using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System.Threading;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator animator;
    public SpriteRenderer character;
    public Vector3 moveInput;
    public LosePanel losePanel;
    Player player;
    Health health;
    private Rigidbody2D rb;
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        health = GetComponent<Health>();
        player = GetComponent<Player>();
    }
    private void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        transform.position += moveInput * moveSpeed * Time.deltaTime;
        animator.SetFloat("Speed", moveInput.sqrMagnitude);
        if (moveInput.x != 0)
        {
            if (moveInput.x > 0)
                character.transform.localScale = new Vector3(1, 1, 0);
            else
                character.transform.localScale = new Vector3(-1, 1, 0);
        }
    }
    public void TakeDamageEffect(int damage)
    {
        AudioManage.instance.PlaySFX("HitPlayer"); //dính dame người kêu
        if (GetComponent<Health>().IsDead)
        {
            animator.SetTrigger("Die");
            moveSpeed = 0;
            AudioManage.instance.musicSource.Stop();
            if (losePanel != null)
            {
                StartCoroutine(showlosePanel());// người chết -> Show ra
            }
        }
    }
    IEnumerator showlosePanel()
    {
        yield return new WaitForSecondsRealtime(0.05f);
        losePanel.Show();
        yield return new WaitForSecondsRealtime(0.5f);
        AudioManage.instance.PlaySFX("Die");
    }
}
