﻿namespace Domain.AbstractFactory
{
    public class FactoryKeyboardNormalWhite : KeyboardAbstractFactory
    {
        public override Color CreateColor()
        {
            return new White();
        }

        public override Keyboard CreateKeyboard()
        {
            return new Normal("Keyboard Normal");
        }
    }
}