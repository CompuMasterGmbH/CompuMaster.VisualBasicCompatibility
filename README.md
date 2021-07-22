# CompuMaster.VisualBasicCompatibility

## Purpose of this project

Add most important, missing API features of `Microsoft.VisualBasic` namespace to .NET Standard 2.0 profile. The required classes are published under the namespace `CompuMaster.VisualBasicCompatibility`. This allows cross-platform solutions of e.g. .NET Framework 4.8 consuming libraries written for .NET 5 by using common .NET Standard 2.0.

## Partial implementations

Especially following partial implementations are available

* ControlChars
  * Cr
  * Lf
  * CrLf
  * VerticalTab
  * NullChar
  * Back
  * FormFeed
* Strings
  * Space
  * Replace
  * Trim
  * LSet
  * RSet
  * LCase
  * UCase
  * InStr
* Information
  * IsDBNull
  * IsNumeric
  * IsDate
  * IsNothing
  * TriState
  * VariantType
