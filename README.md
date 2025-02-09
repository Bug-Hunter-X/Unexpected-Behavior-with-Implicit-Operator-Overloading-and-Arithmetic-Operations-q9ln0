# Unexpected Behavior with Implicit Operator Overloading and Arithmetic Operations in C#

This code demonstrates a potential issue when using implicit operator overloading in C# along with arithmetic operations. While implicit conversions make code cleaner, they can introduce unexpected behavior if not carefully considered.

## Problem Description
The `MyClass` example defines implicit conversions between `MyClass` and `int`. The program shows that basic arithmetic operations may not behave as intuitively expected when combining implicit conversions.