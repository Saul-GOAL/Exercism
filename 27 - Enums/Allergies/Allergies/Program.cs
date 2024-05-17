using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
 
    private Allergen allergens;

    public Allergies(int mask) => 
        allergens = (Allergen)mask;

    public bool IsAllergicTo(Allergen allergen) =>
        allergens.HasFlag(allergen);

    public Allergen[] List() =>
        Enum.GetValues<Allergen>().Where(a => allergens.HasFlag(a)).ToArray();
}