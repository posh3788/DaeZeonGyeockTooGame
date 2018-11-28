﻿using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Linq;

public class WarriorCharacter : BaseCharacter
{

    SkillManager SkillManage;

    private new void Awake()
    {
        base.Awake();
        SkillManage = new SkillManager();
    }

    private void Update()
    {
        SkillManage.Update();
        HealthPoint += 10 * Time.deltaTime;
        EnergyPoint += 50 * Time.deltaTime;
        if (Input.GetKey(KeyCode.Q) == true)
        {
            UseSkill(0);
        }
        if (Input.GetKey(KeyCode.E) == true)
        {
            UseSkill(1);
        }
    }

    IEnumerator AttackMotion(float time)
    {
        Debug.Log("공격 애니메이션 시작!");
        Anim.SetBool("Attack", true);
        yield return new WaitForSeconds(time);
        Anim.SetBool("Attack", false);
    }
    public override void UseSkill(long SkillId)
    {
        StartCoroutine(AttackMotion(0.5f));
        var skill = SkillManage[SkillId];
        skill.Direction = Renderer.flipX ? Vector2.right : Vector2.left;
        skill.Position = this.transform.position;

        SkillManage.OnUseSkill(this, skill);

        OnSkillUse(skill);
    }

    public override void HitSkill(long SkillId)
    {
        var skill = SkillManage[SkillId];

        HealthPoint -= skill.UseHealthPoint;
        EnergyPoint -= skill.UseEnergyPoint;
    }

}