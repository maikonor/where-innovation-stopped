using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using CodeMonkey.Utils;
using UnityEngine.UI;

public class Skilltree : MonoBehaviour
{
    private PlayerSkills playerSkills;

    public SkillTreeButtons[] skillTreeButtonsArray;
    public Dictionary<GameObject, PlayerSkills.Skills> skillButtons = new Dictionary<GameObject, PlayerSkills.Skills>();

    private void Awake()
    {
        playerSkills = new PlayerSkills();
        playerSkills.OnSkillUnlocked += UpdateButton_OnSkillUnlocked;
        
        foreach (SkillTreeButtons skillTreeButton in skillTreeButtonsArray)
        {
            //transform.Find(skillTreeButton.skillButton.name).GetComponent<Button_UI>().ClickFunc = () =>
            skillTreeButton.skillButton.GetComponent<Button_UI>().ClickFunc = () =>
            {
                playerSkills.UnlockSkill(skillTreeButton.skill);
            };
        }
    }

    public void SetPlayerSkills(PlayerSkills playerSkills)
    {
        this.playerSkills = playerSkills;
    }

    private void UpdateButton_OnSkillUnlocked(object sender, PlayerSkills.OnSkillUnlockedEventArgs e)
    {
        foreach(SkillTreeButtons skillTreeButton in skillTreeButtonsArray)
        {
            if (skillTreeButton.skill == e.skill)
            {
                skillTreeButton.skillButton.GetComponent<Image>().color = new Color (255, 255, 255, 255);
                skillTreeButton.skillButton.GetComponent<Button>().enabled = false;
            }
            if (playerSkills.CanUnlockSkill(skillTreeButton.skill))
            {
                skillTreeButton.skillButton.GetComponent<Button>().interactable = true;
            };
        }
    }

    [System.Serializable]
    public class SkillTreeButtons
    {
        public GameObject skillButton;
        public PlayerSkills.Skills skill;
    }
}
