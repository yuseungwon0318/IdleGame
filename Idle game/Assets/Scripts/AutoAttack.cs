using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAttack : MonoBehaviour
{
    public float AttackSpeed = 1;

    void Start()
    {
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {

        while(true)
        {
            Debug.Log("���� ��");

            yield return new WaitForSeconds(AttackSpeed);
        }
       
    }
    void Update()
    {
        
    }
}
