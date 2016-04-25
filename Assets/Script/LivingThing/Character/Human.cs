using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Human : LivingClass {




    #region equipment

    private Weapon weapon;
    private OffHand offHand;
    private Armor armor;
    private Header header;
    private Boot boot;
    private Accessory accessory;

    private Equipment.options options;

    public Equipment.options Options
    {
        get { return options; }
        set { options = value; }
    }

    public void EquipWeapon(Weapon weapon)
    {
        if (weapon != null)
        {
            weapon.UnEquip(this);
        }
        this.weapon.Equip(this);
    }

    public void EquipOffHand(OffHand offHand)
    {
        if (offHand != null)
        {
            offHand.UnEquip(this);
        }
        this.offHand.Equip(this);
    }

    public void EquipArmor(Armor armor)
    {
        if (armor != null)
        {
            armor.UnEquip(this);
        }
        this.armor.Equip(this);
    }

    public void EquipHeader(Header header)
    {
        if (header != null)
        {
            header.UnEquip(this);
        }
        this.header.Equip(this);
    }

    public void EquipBoot(Boot boot)
    {
        if (boot != null)
        {
            boot.UnEquip(this);
        }
        this.boot.Equip(this);
    }

    public void EquipAccessory(Accessory accessory)
    {
        if (accessory != null)
        {
            accessory.UnEquip(this);
        }
        this.accessory.Equip(this);
    }

    public Weapon Weapon
    {
        get { return weapon; }
        set { weapon = value; }
    }
    public OffHand OffHand
    {
        get { return offHand; }
        set { offHand = value; }
    }
    public Armor Armor
    {
        get { return armor; }
        set { armor = value; }
    }
    public Header Header
    {
        get { return header; }
        set { header = value; }
    }
    public Boot Boot
    {
        get { return boot; }
        set { boot = value; }
    }
    public Accessory Accessory
    {
        get { return accessory; }
        set { accessory = value; }
    }

    #endregion
}
