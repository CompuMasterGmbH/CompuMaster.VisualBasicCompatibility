Imports NUnit.Framework

Namespace VisualBasicCompatibilityTest

    Public Class StringsTests

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub ControlChars()
            Assert.AreEqual("    ", CompuMaster.VisualBasicCompatibility.Strings.Space(4))
        End Sub

    End Class

End Namespace