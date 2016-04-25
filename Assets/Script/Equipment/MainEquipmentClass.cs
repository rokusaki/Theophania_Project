using UnityEngine;
using System.Collections;

public class Equipment : IEquipment
{

    private int hp;
    private int mp;
    private int strength;
    private int intelligent;
    private int vitality;
    private int agility;
    private int dexterity;

    private int attack;
    private int magicAttack;
    private int defense;
    private int magicDefense;
    private int speed;
    private int accuracy;

    private int quantity;

    private int additionAttack;
    public delegate void options(ref LivingClass user);

    private event options Options;

    public AttributeStatus CompareEquipment(Equipment first , Equipment second)
    {
        AttributeStatus attributeStatus = new AttributeStatus(first.Attack - second.Attack ,
            first.MagicAttack - second.MagicAttack, 
            first.Defense - second.Defense, 
            first.MagicAttack - second.MagicAttack, 
            first.Speed - second.Speed, 
            first.Accuracy - second.Accuracy);

        return attributeStatus;
    }

    public void AddOption(options option)
    {
        Options += option;
    }

    public void RemoveOption(options option)
    {
        Options -= option;
    }

    public void ClearOptions()
    {
        Options = null;
    }

    public int Hp
    {
        get { return hp; }
        set { hp = value; }
    }
    public int Mp
    {
        get { return mp; }
        set { mp = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Intelligent
    {
        get { return intelligent; }
        set { intelligent = value; }
    }
    public int Vitality
    {
        get { return vitality; }
        set { vitality = value; }
    }
    public int Agility
    {
        get { return agility; }
        set { agility = value; }
    }
    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }
    public int MagicAttack
    {
        get { return magicAttack; }
        set { magicAttack = value; }
    }
    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }
    public int MagicDefense
    {
        get { return magicDefense; }
        set { magicDefense = value; }
    }
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public int Accuracy
    {
        get { return accuracy; }
        set { accuracy = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }


    //Status Modification
    

    public void IncreaseStatus(LivingClass user)
    {
        Debug.Log(user);
        user.Accuracy += Accuracy;
        user.Attack += Attack;
        user.Defense += Defense;
        user.MagicAttack += MagicAttack;
        user.Defense += Defense;
        user.Speed += Speed;
    }

    public void DecreaseStatus(LivingClass user)
    {
        user.Accuracy -= Accuracy;
        user.Attack -= Attack;
        user.Defense -= Defense;
        user.MagicAttack -= MagicAttack;
        user.Defense -= Defense;
        user.Speed -= Speed;
    }

    public void IncreaseAccuracy(LivingClass user)
    {
        user.Accuracy += Accuracy;
    }

    public void IncreaseAttack( LivingClass user)
    {
        user.Attack += Attack;
    }

    public void IncreaseDefense( LivingClass user)
    {
        user.Defense += Defense;
    }

    public void IncreaseMagicAttack( LivingClass user)
    {
        user.MagicAttack += MagicAttack;
    }

    public void IncreaseMagicDefense( LivingClass user)
    {
        user.Defense += Defense;
    }

    public void IncreaseSpeed( LivingClass user)
    {
        user.Speed += Speed;
    }

    public void AddOptions( LivingClass user)
    {

    }

    //Quantity Zone

    public bool Equip(LivingClass user) {
        if (quantity > 0)
        {
            IncreaseStatus(user);
            quantity--;
            return true;
        }
        else
        {
            Debug.LogError("There is no equipment in inventory");
            return false;
        }
    }

    public void UnEquip(LivingClass user)
    {
        quantity++;
    }

    public bool Destroy() {
        if (quantity > 0)
        {
            quantity--;
            return true;
        }
        else
        {
            Debug.LogError("There is no equipment in inventory");
            return false;
        }
    }
}

public interface IEquipment
{
    void IncreaseStatus( LivingClass user);
    void DecreaseStatus(LivingClass user);
    void IncreaseAttack( LivingClass user);
    void IncreaseDefense( LivingClass user);
    void IncreaseMagicAttack( LivingClass user);
    void IncreaseMagicDefense( LivingClass user);
    void IncreaseSpeed( LivingClass user);
    void IncreaseAccuracy( LivingClass user);

    void AddOptions( LivingClass user);
}
