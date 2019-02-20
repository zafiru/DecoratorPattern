﻿namespace DecoratorPattern.Alchemy
{
    public class GreenHerb : IngredientDecorator
    {
        public GreenHerb(IPotion potion)
        {
            Potion = potion;
            Name = potion.Name;
            AddIngrediantName("Green Herb");
        }

        public override int Cost()
        {
            return 2 + Potion.Cost();
        }
    }
}