using UnityEngine;
using System.Collections;

public class LivingClass  {

    public enum LivingType
    {
        Human , Thanatos
    }

    private string name;

    private int maxHp;
    private int hp;
    private int maxMp;
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

    public string Name
    {
        get { return name; }
        set { name = value; }
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
}

public class BodyStatus
{
    private int hp;
    private int mp;
    private int strength;
    private int intelligent;
    private int vitality;
    private int agility;
    private int dexterity;


    public BodyStatus()
    {

    }

    public BodyStatus( int hp, int mp, int strength,  int intelligent, int vitality,int agility, int dexterity)
    {
        hp = this.hp;
          mp = this.mp;
          strength = this.strength;
          intelligent = this.intelligent;
          vitality = this.vitality;
          agility = this.agility;
        dexterity = this.dexterity;
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
}

public class AttributeStatus
{
    private int attack;
    private int magicAttack;
    private int defense;
    private int magicDefense;
    private int speed;
    private int accuracy;

    public AttributeStatus()
    {

    }

    public AttributeStatus(int attack , int magicAttack , int defense,int magicDefense,int speed,int accuracy)
    {
         attack = this.attack;
          magicAttack = this.magicAttack;
          defense = this.defense;
          magicDefense = this.magicDefense;
          speed = this.speed;
          accuracy = this.accuracy;
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
}