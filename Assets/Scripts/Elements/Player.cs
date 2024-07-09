using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpPower;

    public LayerMask jumpLayerMask;

    private Rigidbody2D _rb;
    private CapsuleCollider2D _collider;
    private Animator _animator;
    private bool _isAttacking;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _collider = GetComponent<CapsuleCollider2D>();
        _animator = GetComponent<Animator>();
    }
    public void MoveLeft()
    {
        _rb.AddForce(Vector2.left * Time.deltaTime * speed);
        transform.localScale = new Vector3(1,1,1);

        _animator.SetBool("Run", true);
        _animator.SetBool("Idle", false);
    }
    public void MoveRight()
    {
        _rb.AddForce(Vector2.right * Time.deltaTime * speed);
        transform.localScale = new Vector3(-1, 1, 1);

        _animator.SetBool("Run", true);
        _animator.SetBool("Idle", false);
    }

    private void Update()
    {
        if (_rb.velocity.magnitude <= .5f)
        {
            _animator.SetBool("Run", false);
            _animator.SetBool("Idle", true);
        }
    }

    public void Jump()
    {
        _rb.AddForce(Vector2.up * jumpPower);
    }
    public bool IsTouchingGround()
    {
        RaycastHit2D hit = Physics2D.BoxCast(_collider.bounds.center, _collider.bounds.size, 0, Vector2.down, .3f, jumpLayerMask);
        if (hit.collider == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void Attack()
    {
        if (!GetIfAttacking())
        {
            _animator.SetTrigger("Attack");
            SetAttackingTrue();
            Invoke(nameof(SetAttackingFalse), .7f);
        }
    }

    private void SetAttackingTrue()
    {
        _isAttacking = true;
    }
    private void SetAttackingFalse()
    {
        _isAttacking = false;
    }
    public bool GetIfAttacking()
    {
        return _isAttacking;
    }
    public void GetHit()
    {
        gameObject.SetActive(false);
    }
}
