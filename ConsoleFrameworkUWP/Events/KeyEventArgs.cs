using ConsoleFramework.Native;

namespace ConsoleFramework.Events
{

    internal delegate void KeyEventHandler(object sender, KeyEventArgs args);

    internal class KeyEventArgs : RoutedEventArgs
    {
        public KeyEventArgs(object source, RoutedEvent routedEvent) : base(source, routedEvent)
        {
        }

        public bool bKeyDown;
        public ushort wRepeatCount;
        public VirtualKeys wVirtualKeyCode;
        public ushort wVirtualScanCode;
        public char UnicodeChar;
        public ControlKeyState dwControlKeyState;
    }
}