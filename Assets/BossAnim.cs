using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnim : MonoBehaviour
{
    [SerializeField] private Animator m_AnimatorBoss;
    // Start is called before the first frame update
    void Start()
    {
        m_AnimatorBoss = GetComponent<Animator>();
    }

    public void Material()
    {
        m_AnimatorBoss.Play("ChangeMaterialBoss");
    }
}
