/********************************************************************++
Copyright (c) Microsoft Corporation.  All rights reserved.
--********************************************************************/

using System;
using System.Collections.Generic;

namespace Microsoft.PowerShell
{
    internal static class Keys
    {
        static ConsoleKeyInfo Key(char c)
        {
            return new ConsoleKeyInfo(c, 0, shift: false, alt: false, control: false);
        }

        static ConsoleKeyInfo Key(ConsoleKey key)
        {
            return new ConsoleKeyInfo('\0', key, shift: false, alt: false, control: false);
        }

        static ConsoleKeyInfo Alt(char c)
        {
            return new ConsoleKeyInfo(c, 0, shift: false, alt: true, control: false);
        }

        static ConsoleKeyInfo Alt(ConsoleKey key)
        {
            return new ConsoleKeyInfo('\0', key, shift: false, alt: true, control: false);
        }

        static ConsoleKeyInfo Ctrl(char c)
        {
            return new ConsoleKeyInfo(c, 0, shift: false, alt: false, control: true);
        }

        static ConsoleKeyInfo Ctrl(ConsoleKey key)
        {
            return new ConsoleKeyInfo('\0', key, shift: false, alt: false, control: true);
        }

        static ConsoleKeyInfo Shift(char c)
        {
            return new ConsoleKeyInfo(c, 0, shift: true, alt: false, control: false);
        }

        static ConsoleKeyInfo Shift(ConsoleKey key)
        {
            return new ConsoleKeyInfo('\0', key, shift: true, alt: false, control: false);
        }

        static ConsoleKeyInfo CtrlShiftKey(ConsoleKey key)
        {
            return new ConsoleKeyInfo('\0', key, shift: true, alt: false, control: true);
        }

        public static ConsoleKeyInfo F1           = Key(ConsoleKey.F1);
        public static ConsoleKeyInfo F2           = Key(ConsoleKey.F2);
        public static ConsoleKeyInfo F3           = Key(ConsoleKey.F3);
        public static ConsoleKeyInfo F4           = Key(ConsoleKey.F4);
        public static ConsoleKeyInfo F5           = Key(ConsoleKey.F5);
        public static ConsoleKeyInfo F6           = Key(ConsoleKey.F6);
        public static ConsoleKeyInfo F7           = Key(ConsoleKey.F7);
        public static ConsoleKeyInfo F8           = Key(ConsoleKey.F8);
        public static ConsoleKeyInfo F9           = Key(ConsoleKey.F9);
        public static ConsoleKeyInfo Fl0          = Key(ConsoleKey.F10);
        public static ConsoleKeyInfo F11          = Key(ConsoleKey.F11);
        public static ConsoleKeyInfo F12          = Key(ConsoleKey.F12);
        public static ConsoleKeyInfo F13          = Key(ConsoleKey.F13);
        public static ConsoleKeyInfo F14          = Key(ConsoleKey.F14);
        public static ConsoleKeyInfo F15          = Key(ConsoleKey.F15);
        public static ConsoleKeyInfo F16          = Key(ConsoleKey.F16);
        public static ConsoleKeyInfo F17          = Key(ConsoleKey.F17);
        public static ConsoleKeyInfo F18          = Key(ConsoleKey.F18);
        public static ConsoleKeyInfo F19          = Key(ConsoleKey.F19);
        public static ConsoleKeyInfo F20          = Key(ConsoleKey.F20);
        public static ConsoleKeyInfo F21          = Key(ConsoleKey.F21);
        public static ConsoleKeyInfo F22          = Key(ConsoleKey.F22);
        public static ConsoleKeyInfo F23          = Key(ConsoleKey.F23);
        public static ConsoleKeyInfo F24          = Key(ConsoleKey.F24);
        public static ConsoleKeyInfo _0           = Key('0');
        public static ConsoleKeyInfo _1           = Key('1');
        public static ConsoleKeyInfo _2           = Key('2');
        public static ConsoleKeyInfo _3           = Key('3');
        public static ConsoleKeyInfo _4           = Key('4');
        public static ConsoleKeyInfo _5           = Key('5');
        public static ConsoleKeyInfo _6           = Key('6');
        public static ConsoleKeyInfo _7           = Key('7');
        public static ConsoleKeyInfo _8           = Key('8');
        public static ConsoleKeyInfo _9           = Key('9');
        public static ConsoleKeyInfo A            = Key('a');
        public static ConsoleKeyInfo B            = Key('b');
        public static ConsoleKeyInfo C            = Key('c');
        public static ConsoleKeyInfo D            = Key('d');
        public static ConsoleKeyInfo E            = Key('e');
        public static ConsoleKeyInfo F            = Key('f');
        public static ConsoleKeyInfo G            = Key('g');
        public static ConsoleKeyInfo H            = Key('h');
        public static ConsoleKeyInfo I            = Key('i');
        public static ConsoleKeyInfo J            = Key('j');
        public static ConsoleKeyInfo K            = Key('k');
        public static ConsoleKeyInfo L            = Key('l');
        public static ConsoleKeyInfo M            = Key('m');
        public static ConsoleKeyInfo N            = Key('n');
        public static ConsoleKeyInfo O            = Key('o');
        public static ConsoleKeyInfo P            = Key('p');
        public static ConsoleKeyInfo Q            = Key('q');
        public static ConsoleKeyInfo R            = Key('r');
        public static ConsoleKeyInfo S            = Key('s');
        public static ConsoleKeyInfo T            = Key('t');
        public static ConsoleKeyInfo U            = Key('u');
        public static ConsoleKeyInfo V            = Key('v');
        public static ConsoleKeyInfo W            = Key('w');
        public static ConsoleKeyInfo X            = Key('x');
        public static ConsoleKeyInfo Y            = Key('y');
        public static ConsoleKeyInfo Z            = Key('z');
        public static ConsoleKeyInfo ucA          = Key('A');
        public static ConsoleKeyInfo ucB          = Key('B');
        public static ConsoleKeyInfo ucC          = Key('C');
        public static ConsoleKeyInfo ucD          = Key('D');
        public static ConsoleKeyInfo ucE          = Key('E');
        public static ConsoleKeyInfo ucF          = Key('F');
        public static ConsoleKeyInfo ucG          = Key('G');
        public static ConsoleKeyInfo ucH          = Key('H');
        public static ConsoleKeyInfo ucI          = Key('I');
        public static ConsoleKeyInfo ucJ          = Key('J');
        public static ConsoleKeyInfo ucK          = Key('K');
        public static ConsoleKeyInfo ucL          = Key('L');
        public static ConsoleKeyInfo ucM          = Key('M');
        public static ConsoleKeyInfo ucN          = Key('N');
        public static ConsoleKeyInfo ucO          = Key('O');
        public static ConsoleKeyInfo ucP          = Key('P');
        public static ConsoleKeyInfo ucQ          = Key('Q');
        public static ConsoleKeyInfo ucR          = Key('R');
        public static ConsoleKeyInfo ucS          = Key('S');
        public static ConsoleKeyInfo ucT          = Key('T');
        public static ConsoleKeyInfo ucU          = Key('U');
        public static ConsoleKeyInfo ucV          = Key('V');
        public static ConsoleKeyInfo ucW          = Key('W');
        public static ConsoleKeyInfo ucX          = Key('X');
        public static ConsoleKeyInfo ucY          = Key('Y');
        public static ConsoleKeyInfo ucZ          = Key('Z');
        public static ConsoleKeyInfo Bang         = Key('!');
        public static ConsoleKeyInfo At           = Key('@');
        public static ConsoleKeyInfo Pound        = Key('#');
        public static ConsoleKeyInfo Dollar       = Key('$');
        public static ConsoleKeyInfo Percent      = Key('%');
        public static ConsoleKeyInfo Uphat        = Key('^');
        public static ConsoleKeyInfo Ampersand    = Key('&');
        public static ConsoleKeyInfo Star         = Key('*');
        public static ConsoleKeyInfo LParen       = Key('(');
        public static ConsoleKeyInfo RParen       = Key(')');
        public static ConsoleKeyInfo Colon        = Key(':');
        public static ConsoleKeyInfo Semicolon    = Key(';');
        public static ConsoleKeyInfo Question     = Key('?');
        public static ConsoleKeyInfo Slash        = Key('/');
        public static ConsoleKeyInfo Tilde        = Key('~');
        public static ConsoleKeyInfo Backtick     = Key('`');
        public static ConsoleKeyInfo LCurly       = Key('{');
        public static ConsoleKeyInfo LBracket     = Key('[');
        public static ConsoleKeyInfo Pipe         = Key('|');
        public static ConsoleKeyInfo Backslash    = Key('\\');
        public static ConsoleKeyInfo RCurly       = Key('}');
        public static ConsoleKeyInfo RBracket     = Key(']');
        public static ConsoleKeyInfo SQuote       = Key('\'');
        public static ConsoleKeyInfo DQuote       = Key('"');
        public static ConsoleKeyInfo LessThan     = Key('<');
        public static ConsoleKeyInfo Comma        = Key(',');
        public static ConsoleKeyInfo GreaterThan  = Key('>');
        public static ConsoleKeyInfo Period       = Key('.');
        public static ConsoleKeyInfo Underbar     = Key('_');
        public static ConsoleKeyInfo Minus        = Key('-');
        public static ConsoleKeyInfo Plus         = Key('+');
        public static ConsoleKeyInfo Eq           = Key('=');
        public static ConsoleKeyInfo Space        = Key(' ');
        public static ConsoleKeyInfo Backspace    = Key(ConsoleKey.Backspace);
        public static ConsoleKeyInfo Delete       = Key(ConsoleKey.Delete);
        public static ConsoleKeyInfo DownArrow    = Key(ConsoleKey.DownArrow);
        public static ConsoleKeyInfo End          = Key(ConsoleKey.End);
        public static ConsoleKeyInfo Enter        = Key(ConsoleKey.Enter);
        public static ConsoleKeyInfo Escape       = Key('\x1b');
        public static ConsoleKeyInfo Home         = Key(ConsoleKey.Home);
        public static ConsoleKeyInfo LeftArrow    = Key(ConsoleKey.LeftArrow);
        public static ConsoleKeyInfo RightArrow   = Key(ConsoleKey.RightArrow);
        public static ConsoleKeyInfo Tab          = Key(ConsoleKey.Tab);
        public static ConsoleKeyInfo UpArrow      = Key(ConsoleKey.UpArrow);
        public static ConsoleKeyInfo PageUp       = Key(ConsoleKey.PageUp);
        public static ConsoleKeyInfo PageDown     = Key(ConsoleKey.PageDown);


        public static ConsoleKeyInfo AltF1        = Alt(ConsoleKey.F1);
        public static ConsoleKeyInfo AltF2        = Alt(ConsoleKey.F2);
        public static ConsoleKeyInfo AltF3        = Alt(ConsoleKey.F3);
        public static ConsoleKeyInfo AltF4        = Alt(ConsoleKey.F4);
        public static ConsoleKeyInfo AltF5        = Alt(ConsoleKey.F5);
        public static ConsoleKeyInfo AltF6        = Alt(ConsoleKey.F6);
        public static ConsoleKeyInfo AltF7        = Alt(ConsoleKey.F7);
        public static ConsoleKeyInfo AltF8        = Alt(ConsoleKey.F8);
        public static ConsoleKeyInfo AltF9        = Alt(ConsoleKey.F9);
        public static ConsoleKeyInfo AltFl0       = Alt(ConsoleKey.F10);
        public static ConsoleKeyInfo AltF11       = Alt(ConsoleKey.F11);
        public static ConsoleKeyInfo AltF12       = Alt(ConsoleKey.F12);
        public static ConsoleKeyInfo AltF13       = Alt(ConsoleKey.F13);
        public static ConsoleKeyInfo AltF14       = Alt(ConsoleKey.F14);
        public static ConsoleKeyInfo AltF15       = Alt(ConsoleKey.F15);
        public static ConsoleKeyInfo AltF16       = Alt(ConsoleKey.F16);
        public static ConsoleKeyInfo AltF17       = Alt(ConsoleKey.F17);
        public static ConsoleKeyInfo AltF18       = Alt(ConsoleKey.F18);
        public static ConsoleKeyInfo AltF19       = Alt(ConsoleKey.F19);
        public static ConsoleKeyInfo AltF20       = Alt(ConsoleKey.F20);
        public static ConsoleKeyInfo AltF21       = Alt(ConsoleKey.F21);
        public static ConsoleKeyInfo AltF22       = Alt(ConsoleKey.F22);
        public static ConsoleKeyInfo AltF23       = Alt(ConsoleKey.F23);
        public static ConsoleKeyInfo AltF24       = Alt(ConsoleKey.F24);
        public static ConsoleKeyInfo Alt0         = Alt('0');
        public static ConsoleKeyInfo Alt1         = Alt('1');
        public static ConsoleKeyInfo Alt2         = Alt('2');
        public static ConsoleKeyInfo Alt3         = Alt('3');
        public static ConsoleKeyInfo Alt4         = Alt('4');
        public static ConsoleKeyInfo Alt5         = Alt('5');
        public static ConsoleKeyInfo Alt6         = Alt('6');
        public static ConsoleKeyInfo Alt7         = Alt('7');
        public static ConsoleKeyInfo Alt8         = Alt('8');
        public static ConsoleKeyInfo Alt9         = Alt('9');
        public static ConsoleKeyInfo AltA         = Alt('a');
        public static ConsoleKeyInfo AltB         = Alt('b');
        public static ConsoleKeyInfo AltC         = Alt('c');
        public static ConsoleKeyInfo AltD         = Alt('d');
        public static ConsoleKeyInfo AltE         = Alt('e');
        public static ConsoleKeyInfo AltF         = Alt('f');
        public static ConsoleKeyInfo AltG         = Alt('g');
        public static ConsoleKeyInfo AltH         = Alt('h');
        public static ConsoleKeyInfo AltI         = Alt('i');
        public static ConsoleKeyInfo AltJ         = Alt('j');
        public static ConsoleKeyInfo AltK         = Alt('k');
        public static ConsoleKeyInfo AltL         = Alt('l');
        public static ConsoleKeyInfo AltM         = Alt('m');
        public static ConsoleKeyInfo AltN         = Alt('n');
        public static ConsoleKeyInfo AltO         = Alt('o');
        public static ConsoleKeyInfo AltP         = Alt('p');
        public static ConsoleKeyInfo AltQ         = Alt('q');
        public static ConsoleKeyInfo AltR         = Alt('r');
        public static ConsoleKeyInfo AltS         = Alt('s');
        public static ConsoleKeyInfo AltT         = Alt('t');
        public static ConsoleKeyInfo AltU         = Alt('u');
        public static ConsoleKeyInfo AltV         = Alt('v');
        public static ConsoleKeyInfo AltW         = Alt('w');
        public static ConsoleKeyInfo AltX         = Alt('x');
        public static ConsoleKeyInfo AltY         = Alt('y');
        public static ConsoleKeyInfo AltZ         = Alt('z');
        public static ConsoleKeyInfo AltShiftB    = Alt('B');
        public static ConsoleKeyInfo AltShiftF    = Alt('F');
        public static ConsoleKeyInfo AltSpace     = Alt(' ');  // Useless, system menu.
        public static ConsoleKeyInfo AltPeriod    = Alt('.');
        public static ConsoleKeyInfo AltEquals    = Alt('=');
        public static ConsoleKeyInfo AltMinus     = Alt('-');
        public static ConsoleKeyInfo AltUnderbar  = Alt('_');
        public static ConsoleKeyInfo AltBackspace = Alt(ConsoleKey.Backspace);
        public static ConsoleKeyInfo AltLess      = Alt('<');
        public static ConsoleKeyInfo AltGreater   = Alt('>');
        public static ConsoleKeyInfo AltQuestion  = Alt('?');
        public static ConsoleKeyInfo AltPageUp    = Alt(ConsoleKey.PageUp);
        public static ConsoleKeyInfo AltPageDown  = Alt(ConsoleKey.PageDown);


        public static ConsoleKeyInfo CtrlA          = Ctrl('\x01');
        public static ConsoleKeyInfo CtrlB          = Ctrl('\x02');
        public static ConsoleKeyInfo CtrlC          = Ctrl('\x03');
        public static ConsoleKeyInfo CtrlD          = Ctrl('\x04');
        public static ConsoleKeyInfo CtrlE          = Ctrl('\x05');
        public static ConsoleKeyInfo CtrlF          = Ctrl('\x06');
        public static ConsoleKeyInfo CtrlG          = Ctrl('\a');
        public static ConsoleKeyInfo CtrlH          = Ctrl('\b');
        public static ConsoleKeyInfo CtrlI          = Ctrl('\t');
        public static ConsoleKeyInfo CtrlJ          = Ctrl('\n');
        public static ConsoleKeyInfo CtrlK          = Ctrl('\v');
        public static ConsoleKeyInfo CtrlL          = Ctrl('\f');
        public static ConsoleKeyInfo CtrlM          = Ctrl('\r');
        public static ConsoleKeyInfo CtrlN          = Ctrl('\x0e');
        public static ConsoleKeyInfo CtrlO          = Ctrl('\x0f');
        public static ConsoleKeyInfo CtrlP          = Ctrl('\x10');
        public static ConsoleKeyInfo CtrlQ          = Ctrl('\x11');
        public static ConsoleKeyInfo CtrlR          = Ctrl('\x12');
        public static ConsoleKeyInfo CtrlS          = Ctrl('\x13');
        public static ConsoleKeyInfo CtrlT          = Ctrl('\x14');
        public static ConsoleKeyInfo CtrlU          = Ctrl('\x15');
        public static ConsoleKeyInfo CtrlV          = Ctrl('\x16');
        public static ConsoleKeyInfo CtrlW          = Ctrl('\x17');
        public static ConsoleKeyInfo CtrlX          = Ctrl('\x18');
        public static ConsoleKeyInfo CtrlY          = Ctrl('\x19');
        public static ConsoleKeyInfo CtrlZ          = Ctrl('\x1a');
        public static ConsoleKeyInfo CtrlSpace      = Ctrl(' ');
        public static ConsoleKeyInfo CtrlAt         = Ctrl('\0');
        public static ConsoleKeyInfo CtrlRBracket   = Ctrl('\x1d');
        public static ConsoleKeyInfo CtrlUnderbar   = Ctrl('\x1f');
        public static ConsoleKeyInfo CtrlDelete     = Ctrl(ConsoleKey.Delete);
        public static ConsoleKeyInfo CtrlEnd        = Ctrl(ConsoleKey.End);
        public static ConsoleKeyInfo CtrlHome       = Ctrl(ConsoleKey.Home);
        public static ConsoleKeyInfo CtrlPageUp     = Ctrl(ConsoleKey.PageUp);
        public static ConsoleKeyInfo CtrlPageDown   = Ctrl(ConsoleKey.PageDown);
        public static ConsoleKeyInfo CtrlLeftArrow  = Ctrl(ConsoleKey.LeftArrow);
        public static ConsoleKeyInfo CtrlRightArrow = Ctrl(ConsoleKey.RightArrow);
        public static ConsoleKeyInfo CtrlEnter      = Ctrl(ConsoleKey.Enter);


        public static ConsoleKeyInfo ShiftF3         = Shift(ConsoleKey.F3);
        public static ConsoleKeyInfo ShiftF8         = Shift(ConsoleKey.F8);
        public static ConsoleKeyInfo ShiftEnd        = Shift(ConsoleKey.End);
        public static ConsoleKeyInfo ShiftEnter      = Shift(ConsoleKey.Enter);
        public static ConsoleKeyInfo ShiftHome       = Shift(ConsoleKey.Home);
        public static ConsoleKeyInfo ShiftPageUp     = Shift(ConsoleKey.PageUp);
        public static ConsoleKeyInfo ShiftPageDown   = Shift(ConsoleKey.PageDown);
        public static ConsoleKeyInfo ShiftLeftArrow  = Shift(ConsoleKey.LeftArrow);
        public static ConsoleKeyInfo ShiftRightArrow = Shift(ConsoleKey.RightArrow);
        public static ConsoleKeyInfo ShiftTab        = Shift(ConsoleKey.);

        // Can't detect on Linux
        public static ConsoleKeyInfo CtrlShiftC      = new ConsoleKeyInfo('\x03', ConsoleKey.C, true, false, true);

        //
        public static ConsoleKeyInfo CtrlShiftEnter = new ConsoleKeyInfo('\x00',  ConsoleKey.Enter, true, false, true);

        public static ConsoleKeyInfo AltCtrlY = new ConsoleKeyInfo('\x00', ConsoleKey.Y, false, true, true);
        public static ConsoleKeyInfo AltCtrlRBracket = new ConsoleKeyInfo('\x00', ConsoleKey.Oem6, false, true, true);

        public static ConsoleKeyInfo CtrlAltQuestion = new ConsoleKeyInfo('\x00', ConsoleKey.Oem2, true, true, true);
        public static ConsoleKeyInfo CtrlBackspace = new ConsoleKeyInfo((char)0x7f, ConsoleKey.Backspace, false, false, true);

        public static ConsoleKeyInfo CtrlShiftLeftArrow  = CtrlShiftKey(ConsoleKey.LeftArrow);
        public static ConsoleKeyInfo CtrlShiftRightArrow = CtrlShiftKey(ConsoleKey.RightArrow);

        private static bool IgnoreKeyChar(ConsoleKeyInfo key)
        {
            return key.KeyChar == '\x00' ||
                key.Key == ConsoleKey.Backspace ||
                key.Key == ConsoleKey.Enter;
        }

        private static ConsoleModifiers NormalizeModifiers(ConsoleKeyInfo key)
        {
            var result = key.Modifiers;
            if (!char.IsControl(key.KeyChar))
            {
                // Ignore Shift state unless it's a control character.
                result = result & ~ConsoleModifiers.Shift;
            }

            return result;
        }

        internal static bool NormalizedEquals(ConsoleKeyInfo x, ConsoleKeyInfo y)
        {
            // In the common case, we mask something out of the ConsoleKeyInfo
            // e.g. Shift or somewhat meaningless Key (like Oem6) which might vary
            // in different keyboard layouts.
            //
            // That said, if all fields compare, it's a match and we return that.
            if (x.Key == y.Key && x.KeyChar == y.KeyChar && x.Modifiers == y.Modifiers)
                return true;

            // We ignore Shift state as that can vary in different keyboard layouts.
            var xMods = x.Modifiers & ~ConsoleModifiers.Shift;
            var yMods = y.Modifiers & ~ConsoleModifiers.Shift;

            if (xMods != yMods)
                return false;

            // If we don't have a character, we probably masked it out (except for Ctrl+@)
            // when building our key bindings, so compare Key instead.
            if (x.KeyChar == '\0' || y.KeyChar == '\0')
            {
                return x.Key == y.Key;
            }

            return x.KeyChar == y.KeyChar;
        }

        internal static int NormalizedHashCode(ConsoleKeyInfo obj)
        {
            // Because a comparison of two ConsoleKeyInfo objects is a comparison of the
            // combination of the ConsoleKey and Modifiers, we must combine their hashes.
            // Note that if the ConsoleKey is default, we must fall back to the KeyChar,
            // otherwise every non-special key will compare as the same.
            int h1 = obj.KeyChar != '\0'
                ? obj.KeyChar.GetHashCode()
                : obj.Key.GetHashCode();

            int h2 = (obj.Modifiers & ~ConsoleModifiers.Shift).GetHashCode();
            // This is based on Tuple.GetHashCode
            return unchecked(((h1 << 5) + h1) ^ h2);
        }

        // Keys to ignore
        public static ConsoleKeyInfo VolumeUp   = new ConsoleKeyInfo((char)0, ConsoleKey.VolumeUp, false, false, false);
        public static ConsoleKeyInfo VolumeDown = new ConsoleKeyInfo((char)0, ConsoleKey.VolumeDown, false, false, false);
        public static ConsoleKeyInfo VolumeMute = new ConsoleKeyInfo((char)0, ConsoleKey.VolumeMute, false, false, false);
    }
}
