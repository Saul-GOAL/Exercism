using System;

abstract class Character
{
    protected string CharacterType => 
        GetType().Name;

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => 
        false;

    public override string ToString() => 
        $"Character is a {CharacterType}";
}

class Warrior : Character
{
    public override int DamagePoints(Character target) => 
        (target.Vulnerable() ? 10 : 6);

}

class Wizard : Character
{
    private bool isSpellPrepared = false;

    public override int DamagePoints(Character target) => 
        (isSpellPrepared ? 12 : 3);

    public override bool Vulnerable() => 
        !(isSpellPrepared);

    public void PrepareSpell() => 
        isSpellPrepared = true;
}
