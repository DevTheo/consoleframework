using System;
using System.Diagnostics;
using ConsoleFramework.Core;
using ConsoleFramework.Events;
using ConsoleFramework.Native;
using ConsoleFramework.Rendering;

namespace ConsoleFramework.Controls
{
    internal class ConsoleKeyInfo : object
    {
        internal ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control)
        {
            this.KeyChar = keyChar;
            this.Key = key;
            this.shift = shift;
            this.alt = alt;
            this.control = control;
        }

        public ConsoleKey Key { get; }
        public char KeyChar { get; }
        private readonly bool shift;
        private readonly bool alt;
        private readonly bool control;
        public ConsoleModifiers Modifiers
        {
            get
            {
                return (ConsoleModifiers) ((shift ? (int) ConsoleModifiers.Shift : 0) +
                    (alt ? (int) ConsoleModifiers.Alt : 0) +
                    (control ? (int) ConsoleModifiers.Control : 0));
            }
        }
        public override bool Equals(object value)
        {
            if (value is ConsoleKeyInfo)
                return this.Equals((ConsoleKeyInfo) value);
            return false;
        }

        public bool Equals(ConsoleKeyInfo obj)
        {
            return obj.Key == this.Key &&
                obj.KeyChar == this.KeyChar &&
                obj.shift == this.shift &&
                obj.alt == this.alt &&
                obj.control == this.control;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        //public static bool operator ==(ConsoleKeyInfo a, ConsoleKeyInfo b);
        //public static bool operator !=(ConsoleKeyInfo a, ConsoleKeyInfo b);
    }
}