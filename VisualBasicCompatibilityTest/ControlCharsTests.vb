Imports NUnit.Framework

Namespace VisualBasicCompatibilityTest

    <TestFixture> Public Class ControlCharsTests

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub ControlChars()
            Assert.AreEqual(ChrW(9), CompuMaster.VisualBasicCompatibility.ControlChars.Tab)
            Assert.AreEqual(ChrW(13), CompuMaster.VisualBasicCompatibility.ControlChars.Cr)
            Assert.AreEqual(ChrW(10), CompuMaster.VisualBasicCompatibility.ControlChars.Lf)
            Assert.AreEqual(ChrW(13) & ChrW(10), CompuMaster.VisualBasicCompatibility.ControlChars.CrLf)
            Assert.AreEqual(ChrW(11), CompuMaster.VisualBasicCompatibility.ControlChars.VerticalTab)
            Assert.AreEqual(ChrW(0), CompuMaster.VisualBasicCompatibility.ControlChars.NullChar)
            Assert.AreEqual(ChrW(8), CompuMaster.VisualBasicCompatibility.ControlChars.Back)
            Assert.AreEqual(ChrW(12), CompuMaster.VisualBasicCompatibility.ControlChars.FormFeed)
        End Sub

    End Class

End Namespace