using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerSkills : MonoBehaviour
{
    //Code from https://www.youtube.com/watch?v=_OQTTKkwZQY

    public event EventHandler<OnSkillUnlockedEventArgs> OnSkillUnlocked;
    public class OnSkillUnlockedEventArgs: EventArgs
    {
        public Skills skill;
    }
    
    public enum Skills
    {
        None,
        Speed1,
        Speed2,
    }

    private List<Skills> unlockedSkillsList;

    public PlayerSkills()
    {
        unlockedSkillsList = new List<Skills>();
    }

    public void UnlockSkill(Skills skill)
    {
        if (!IsSkillUnlocked(skill))
        {
            unlockedSkillsList.Add(skill);
            OnSkillUnlocked?.Invoke(this, new OnSkillUnlockedEventArgs { skill = skill });
        }
    }

    public bool IsSkillUnlocked(Skills skill)
    {
        return unlockedSkillsList.Contains(skill);
    }

    public Skills GetSkillRequirement(Skills skill)
    {
        switch (skill)
        {
            case Skills.Speed2: return Skills.Speed1;
        }
        return Skills.None;
    }

    public bool CanUnlockSkill (Skills skill)
    {
        Skills skillRequirement = GetSkillRequirement(skill);

        if(skillRequirement != Skills.None)
        {
            if (IsSkillUnlocked(skillRequirement))
            {
                //UnlockSkill(skill);
                return true;
            } else {
                return false;
            }
        } else {
            //UnlockSkill(skill);
            return true;
        }
    }
}
