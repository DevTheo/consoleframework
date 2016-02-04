using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleFramework.Controls
{
    public enum ConsoleKey
    {
        Backspace = 8,
        Tab = 9,
        Clear = 12,
        Enter = 13,
        Pause = 19,
        Escape = 27,
        Spacebar = 32,
        PageUp = 33,
        PageDown = 34,
        End = 35,
        Home = 36,
        LeftArrow = 37,
        UpArrow = 38,
        RightArrow = 39,
        DownArrow = 40,
        Select = 41,
        Print = 42,
        Execute = 43,
        PrintScreen = 44,
        Insert = 45,
        Delete = 46,
        Help = 47,
        D0 = 48,
        D1 = 49,
        D2 = 50,
        D3 = 51,
        D4 = 52,
        //
        // Summary:
        //     The 5 key.
        D5 = 53,
        //
        // Summary:
        //     The 6 key.
        D6 = 54,
        //
        // Summary:
        //     The 7 key.
        D7 = 55,
        //
        // Summary:
        //     The 8 key.
        D8 = 56,
        //
        // Summary:
        //     The 9 key.
        D9 = 57,
        //
        // Summary:
        //     The A key.
        A = 65,
        //
        // Summary:
        //     The B key.
        B = 66,
        //
        // Summary:
        //     The C key.
        C = 67,
        //
        // Summary:
        //     The D key.
        D = 68,
        //
        // Summary:
        //     The E key.
        E = 69,
        //
        // Summary:
        //     The F key.
        F = 70,
        //
        // Summary:
        //     The G key.
        G = 71,
        //
        // Summary:
        //     The H key.
        H = 72,
        //
        // Summary:
        //     The I key.
        I = 73,
        //
        // Summary:
        //     The J key.
        J = 74,
        //
        // Summary:
        //     The K key.
        K = 75,
        //
        // Summary:
        //     The L key.
        L = 76,
        //
        // Summary:
        //     The M key.
        M = 77,
        //
        // Summary:
        //     The N key.
        N = 78,
        //
        // Summary:
        //     The O key.
        O = 79,
        //
        // Summary:
        //     The P key.
        P = 80,
        //
        // Summary:
        //     The Q key.
        Q = 81,
        //
        // Summary:
        //     The R key.
        R = 82,
        //
        // Summary:
        //     The S key.
        S = 83,
        //
        // Summary:
        //     The T key.
        T = 84,
        //
        // Summary:
        //     The U key.
        U = 85,
        //
        // Summary:
        //     The V key.
        V = 86,
        //
        // Summary:
        //     The W key.
        W = 87,
        //
        // Summary:
        //     The X key.
        X = 88,
        //
        // Summary:
        //     The Y key.
        Y = 89,
        //
        // Summary:
        //     The Z key.
        Z = 90,
        //
        // Summary:
        //     The left Windows logo key (Microsoft Natural Keyboard).
        LeftWindows = 91,
        //
        // Summary:
        //     The right Windows logo key (Microsoft Natural Keyboard).
        RightWindows = 92,
        //
        // Summary:
        //     The Application key (Microsoft Natural Keyboard).
        Applications = 93,
        //
        // Summary:
        //     The Computer Sleep key.
        Sleep = 95,
        //
        // Summary:
        //     The 0 key on the numeric keypad.
        NumPad0 = 96,
        //
        // Summary:
        //     The 1 key on the numeric keypad.
        NumPad1 = 97,
        //
        // Summary:
        //     The 2 key on the numeric keypad.
        NumPad2 = 98,
        //
        // Summary:
        //     The 3 key on the numeric keypad.
        NumPad3 = 99,
        //
        // Summary:
        //     The 4 key on the numeric keypad.
        NumPad4 = 100,
        //
        // Summary:
        //     The 5 key on the numeric keypad.
        NumPad5 = 101,
        //
        // Summary:
        //     The 6 key on the numeric keypad.
        NumPad6 = 102,
        //
        // Summary:
        //     The 7 key on the numeric keypad.
        NumPad7 = 103,
        //
        // Summary:
        //     The 8 key on the numeric keypad.
        NumPad8 = 104,
        //
        // Summary:
        //     The 9 key on the numeric keypad.
        NumPad9 = 105,
        //
        // Summary:
        //     The Multiply key.
        Multiply = 106,
        //
        // Summary:
        //     The Add key.
        Add = 107,
        //
        // Summary:
        //     The Separator key.
        Separator = 108,
        //
        // Summary:
        //     The Subtract key.
        Subtract = 109,
        //
        // Summary:
        //     The Decimal key.
        Decimal = 110,
        //
        // Summary:
        //     The Divide key.
        Divide = 111,
        //
        // Summary:
        //     The F1 key.
        F1 = 112,
        //
        // Summary:
        //     The F2 key.
        F2 = 113,
        //
        // Summary:
        //     The F3 key.
        F3 = 114,
        //
        // Summary:
        //     The F4 key.
        F4 = 115,
        //
        // Summary:
        //     The F5 key.
        F5 = 116,
        //
        // Summary:
        //     The F6 key.
        F6 = 117,
        //
        // Summary:
        //     The F7 key.
        F7 = 118,
        //
        // Summary:
        //     The F8 key.
        F8 = 119,
        //
        // Summary:
        //     The F9 key.
        F9 = 120,
        //
        // Summary:
        //     The F10 key.
        F10 = 121,
        //
        // Summary:
        //     The F11 key.
        F11 = 122,
        //
        // Summary:
        //     The F12 key.
        F12 = 123,
        //
        // Summary:
        //     The F13 key.
        F13 = 124,
        //
        // Summary:
        //     The F14 key.
        F14 = 125,
        //
        // Summary:
        //     The F15 key.
        F15 = 126,
        //
        // Summary:
        //     The F16 key.
        F16 = 127,
        //
        // Summary:
        //     The F17 key.
        F17 = 128,
        //
        // Summary:
        //     The F18 key.
        F18 = 129,
        //
        // Summary:
        //     The F19 key.
        F19 = 130,
        //
        // Summary:
        //     The F20 key.
        F20 = 131,
        //
        // Summary:
        //     The F21 key.
        F21 = 132,
        //
        // Summary:
        //     The F22 key.
        F22 = 133,
        //
        // Summary:
        //     The F23 key.
        F23 = 134,
        //
        // Summary:
        //     The F24 key.
        F24 = 135,
        //
        // Summary:
        //     The Browser Back key (Windows 2000 or later).
        BrowserBack = 166,
        //
        // Summary:
        //     The Browser Forward key (Windows 2000 or later).
        BrowserForward = 167,
        //
        // Summary:
        //     The Browser Refresh key (Windows 2000 or later).
        BrowserRefresh = 168,
        //
        // Summary:
        //     The Browser Stop key (Windows 2000 or later).
        BrowserStop = 169,
        //
        // Summary:
        //     The Browser Search key (Windows 2000 or later).
        BrowserSearch = 170,
        //
        // Summary:
        //     The Browser Favorites key (Windows 2000 or later).
        BrowserFavorites = 171,
        //
        // Summary:
        //     The Browser Home key (Windows 2000 or later).
        BrowserHome = 172,
        //
        // Summary:
        //     The Volume Mute key (Microsoft Natural Keyboard, Windows 2000 or later).
        VolumeMute = 173,
        //
        // Summary:
        //     The Volume Down key (Microsoft Natural Keyboard, Windows 2000 or later).
        VolumeDown = 174,
        //
        // Summary:
        //     The Volume Up key (Microsoft Natural Keyboard, Windows 2000 or later).
        VolumeUp = 175,
        //
        // Summary:
        //     The Media Next Track key (Windows 2000 or later).
        MediaNext = 176,
        //
        // Summary:
        //     The Media Previous Track key (Windows 2000 or later).
        MediaPrevious = 177,
        //
        // Summary:
        //     The Media Stop key (Windows 2000 or later).
        MediaStop = 178,
        //
        // Summary:
        //     The Media Play/Pause key (Windows 2000 or later).
        MediaPlay = 179,
        //
        // Summary:
        //     The Start Mail key (Microsoft Natural Keyboard, Windows 2000 or later).
        LaunchMail = 180,
        //
        // Summary:
        //     The Select Media key (Microsoft Natural Keyboard, Windows 2000 or later).
        LaunchMediaSelect = 181,
        //
        // Summary:
        //     The Start Application 1 key (Microsoft Natural Keyboard, Windows 2000 or later).
        LaunchApp1 = 182,
        //
        // Summary:
        //     The Start Application 2 key (Microsoft Natural Keyboard, Windows 2000 or later).
        LaunchApp2 = 183,
        //
        // Summary:
        //     The OEM 1 key (OEM specific).
        Oem1 = 186,
        //
        // Summary:
        //     The OEM Plus key on any country/region keyboard (Windows 2000 or later).
        OemPlus = 187,
        //
        // Summary:
        //     The OEM Comma key on any country/region keyboard (Windows 2000 or later).
        OemComma = 188,
        //
        // Summary:
        //     The OEM Minus key on any country/region keyboard (Windows 2000 or later).
        OemMinus = 189,
        //
        // Summary:
        //     The OEM Period key on any country/region keyboard (Windows 2000 or later).
        OemPeriod = 190,
        //
        // Summary:
        //     The OEM 2 key (OEM specific).
        Oem2 = 191,
        //
        // Summary:
        //     The OEM 3 key (OEM specific).
        Oem3 = 192,
        //
        // Summary:
        //     The OEM 4 key (OEM specific).
        Oem4 = 219,
        //
        // Summary:
        //     The OEM 5 (OEM specific).
        Oem5 = 220,
        //
        // Summary:
        //     The OEM 6 key (OEM specific).
        Oem6 = 221,
        //
        // Summary:
        //     The OEM 7 key (OEM specific).
        Oem7 = 222,
        //
        // Summary:
        //     The OEM 8 key (OEM specific).
        Oem8 = 223,
        //
        // Summary:
        //     The OEM 102 key (OEM specific).
        Oem102 = 226,
        //
        // Summary:
        //     The IME PROCESS key.
        Process = 229,
        //
        // Summary:
        //     The PACKET key (used to pass Unicode characters with keystrokes).
        Packet = 231,
        //
        // Summary:
        //     The ATTN key.
        Attention = 246,
        //
        // Summary:
        //     The CRSEL (CURSOR SELECT) key.
        CrSel = 247,
        //
        // Summary:
        //     The EXSEL (EXTEND SELECTION) key.
        ExSel = 248,
        //
        // Summary:
        //     The ERASE EOF key.
        EraseEndOfFile = 249,
        //
        // Summary:
        //     The PLAY key.
        Play = 250,
        //
        // Summary:
        //     The ZOOM key.
        Zoom = 251,
        //
        // Summary:
        //     A constant reserved for future use.
        NoName = 252,
        //
        // Summary:
        //     The PA1 key.
        Pa1 = 253,
        //
        // Summary:
        //     The CLEAR key (OEM specific).
        OemClear = 254
    }

}
