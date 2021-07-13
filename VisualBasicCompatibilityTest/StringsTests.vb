Imports NUnit.Framework
Imports CompuMaster.VisualBasicCompatibility

Namespace VisualBasicCompatibilityTest

    <TestFixture> Public Class StringsTests

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test> Public Sub MidTest()
            Assert.AreEqual(Nothing, Strings.Mid(Nothing, 2))
            Assert.AreEqual("", Strings.Mid(Nothing, 2, 2))
            Assert.AreEqual("bcdef", Strings.Mid("abcdef", 2))
            Assert.AreEqual("bc", Strings.Mid("abcdef", 2, 2))
            Assert.AreEqual("", Strings.Mid("", 2))
            Assert.AreEqual("", Strings.Mid("", 2, 2))
        End Sub

        <Test> Public Sub ReplaceTest()
            Assert.AreEqual(Nothing, Strings.Replace(Nothing, "kj", "DD"))
            Assert.AreEqual("abcDEfDEf", Strings.Replace("abcdefdef", "de", "DE"))
            Assert.AreEqual("abcdefdef", Strings.Replace("abcdefdef", "kj", "DD"))
            'Assert.AreEqual(Nothing, Strings.Replace(String.Empty, "kj", "DD")) 'MS VisualBasic behaviour
            Assert.AreEqual("", Strings.Replace(String.Empty, "kj", "DD")) 'CM.Data behaviour
        End Sub

        <Test> Public Sub SpaceTest()
            Assert.AreEqual("", Strings.Space(0))
            Assert.AreEqual("    ", Strings.Space(4))
        End Sub

        <Test> Public Sub TrimTest()
            Assert.AreEqual("", Strings.Trim(Nothing))
            Assert.AreEqual("", Strings.Trim(String.Empty))
            Assert.AreEqual("", Strings.Trim("    "))
            Assert.AreEqual("÷LKJ", Strings.Trim("  ÷LKJ  "))
        End Sub

        <Test> Public Sub LenTest()
            Assert.AreEqual(0, Strings.Len(CType(Nothing, String)))
            Assert.AreEqual(0, Strings.Len(String.Empty))
            Assert.AreEqual(4, Strings.Len("    "))
            Assert.AreEqual(8, Strings.Len("  ÷LKJ  "))
            Assert.AreEqual(0, Strings.Len(CType(Nothing, Object)))
            Assert.AreEqual(4, Strings.Len(0))
            Assert.AreEqual(1, Strings.Len(Byte.MaxValue))
            Assert.AreEqual(4, Strings.Len(0!))
            Assert.AreEqual(8, Strings.Len(0D))
            Assert.AreEqual(8, Strings.Len(0L))
            Assert.AreEqual(8, Strings.Len(New DateTime))
            Assert.AreEqual(8, Strings.Len(New DateTime(2020, 1, 1)))
            Assert.AreEqual(0, Strings.Len(New TimeSpan))
            Assert.AreEqual(0, Strings.Len(New TimeSpan(20, 10, 15)))
            'Assert.AreEqual(0, Strings.Len(New Byte() {}))
            'Assert.AreEqual(2, Strings.Len(New Integer() {1, 2}))
        End Sub

        <Test> Public Sub StrDupTest()
            Assert.AreEqual("", Strings.StrDup(0, "K"c))
            Assert.AreEqual("    ", Strings.StrDup(4, " "c))
            Assert.AreEqual("KKKK", Strings.StrDup(4, "K"c))
            Assert.AreEqual("", Strings.StrDup(0, "K"c))
            'Assert.AreEqual("    ", Strings.StrDup(4, " "))
            'Assert.AreEqual("KKKK", Strings.StrDup(4, "K"))
            'Assert.AreEqual("KKKK", Strings.StrDup(4, "KK"))
        End Sub

        <Test> Public Sub InStrTest()
            Assert.AreEqual(0, Strings.InStr(Nothing, Nothing))
            Assert.AreEqual(0, Strings.InStr(Nothing, String.Empty))
            Assert.AreEqual(0, Strings.InStr(String.Empty, String.Empty))
            Assert.AreEqual(1, Strings.InStr("abcdefdef", String.Empty))
            Assert.AreEqual(0, Strings.InStr("abcdefdef", "DE"))
            Assert.AreEqual(4, Strings.InStr("abcdefdef", "de"))
        End Sub

        <Test> Public Sub LSetTest()
            Assert.AreEqual("", Strings.LSet("text", 0))
            Assert.AreEqual("tex", Strings.LSet("text", 3))
            Assert.AreEqual("text", Strings.LSet("text", 4))
            Assert.AreEqual("text    ", Strings.LSet("text", 8))
            Assert.AreEqual("", Strings.LSet("", 0))
            Assert.AreEqual("   ", Strings.LSet("", 3))
            Assert.AreEqual("    ", Strings.LSet("", 4))
            Assert.AreEqual("        ", Strings.LSet("", 8))
            Assert.AreEqual("", Strings.LSet(Nothing, 0))
            Assert.AreEqual("   ", Strings.LSet(Nothing, 3))
            Assert.AreEqual("    ", Strings.LSet(Nothing, 4))
            Assert.AreEqual("        ", Strings.LSet(Nothing, 8))
        End Sub

        <Test> Public Sub RSetTest()
            Assert.AreEqual("", Strings.RSet("text", 0))
            Assert.AreEqual("tex", Strings.RSet("text", 3))
            Assert.AreEqual("text", Strings.RSet("text", 4))
            Assert.AreEqual("    text", Strings.RSet("text", 8))
            Assert.AreEqual("", Strings.RSet("", 0))
            Assert.AreEqual("   ", Strings.RSet("", 3))
            Assert.AreEqual("    ", Strings.RSet("", 4))
            Assert.AreEqual("        ", Strings.RSet("", 8))
            Assert.AreEqual("", Strings.RSet(Nothing, 0))
            Assert.AreEqual("   ", Strings.RSet(Nothing, 3))
            Assert.AreEqual("    ", Strings.RSet(Nothing, 4))
            Assert.AreEqual("        ", Strings.RSet(Nothing, 8))
        End Sub

        <Test> Public Sub LCaseTest()
            'Assert.AreEqual(ChrW(0), Strings.LCase(Nothing)) 'MS.VisualBasic behaviour
            Assert.AreEqual("", Strings.LCase(Nothing)) 'CM.Data behaviour
            Assert.AreEqual("", Strings.LCase(""))
            Assert.AreEqual("abcdefdef", Strings.LCase("abcDEfdef"))
            Assert.AreEqual("abcdefdef‰ˆ¸ﬂ", Strings.LCase("abcDEfdef‰÷¸ﬂ"))
        End Sub

        <Test> Public Sub UCaseTest()
            'Assert.AreEqual(ChrW(0), Strings.UCase(Nothing)) 'MS.VisualBasic behaviour
            Assert.AreEqual("", Strings.UCase(Nothing)) 'CM.Data behaviour
            Assert.AreEqual("", Strings.UCase(""))
            Assert.AreEqual("ABCDEFDEF", Strings.UCase("abcDEfdef"))
            Assert.AreEqual("ABCDEFDEFƒ÷‹ﬂ", Strings.UCase("abcDEfdef‰÷¸ﬂ"))
        End Sub

    End Class

End Namespace