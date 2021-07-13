Option Strict On
Option Explicit On

Imports NUnit.Framework

Namespace VisualBasicCompatibilityTest

    <TestFixture> Public Class InformationTests

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test> Public Sub IsDbNullTest()
            Assert.IsTrue(Information.IsDBNull(DBNull.Value))
            Assert.IsFalse(Information.IsDBNull(Nothing))
            Assert.IsFalse(Information.IsDBNull(String.Empty))
            Assert.IsFalse(Information.IsDBNull(2.0))
            Assert.IsFalse(Information.IsDBNull(New Object))
        End Sub

        <Test> Public Sub IsNothingTest()
            Assert.IsFalse(Information.IsNothing(DBNull.Value))
            Assert.IsTrue(Information.IsNothing(Nothing))
            Assert.IsTrue(Information.IsNothing(CType(Nothing, String)))
            Assert.IsFalse(Information.IsNothing(String.Empty))
            Assert.IsFalse(Information.IsNothing(0))
            Assert.IsFalse(Information.IsNothing(New Object))
            Assert.IsFalse(Information.IsNothing(New Object()))
            Assert.IsTrue(Information.IsNothing(CType(Nothing, Object())))
        End Sub

        <Test> Public Sub IsNumericTest()
            Assert.IsFalse(Information.IsNumeric(DBNull.Value))
            Assert.IsFalse(Information.IsNumeric(Nothing))
            Assert.IsFalse(Information.IsNumeric(CType(Nothing, String)))
            Assert.IsFalse(Information.IsNumeric(String.Empty))
            Assert.IsTrue(Information.IsNumeric(True))
            Assert.IsTrue(Information.IsNumeric(0))
            Assert.IsTrue(Information.IsNumeric(0S))
            Assert.IsTrue(Information.IsNumeric(Byte.MaxValue))
            Assert.IsTrue(Information.IsNumeric(2.0!))
            Assert.IsTrue(Information.IsNumeric(2.0))
            Assert.IsTrue(Information.IsNumeric(20L))
            Assert.IsTrue(Information.IsNumeric(-200D))
            Assert.IsFalse(Information.IsNumeric(New Object))
            Assert.IsFalse(Information.IsNumeric(New Byte() {200}))
        End Sub

        <Test> Public Sub IsDateTest()
            Assert.IsFalse(Information.IsDate(DBNull.Value))
            Assert.IsFalse(Information.IsDate(Nothing))
            Assert.IsFalse(Information.IsDate(CType(Nothing, String)))
            Assert.IsFalse(Information.IsDate(String.Empty))
            Assert.IsFalse(Information.IsDate(0))
            Assert.IsFalse(Information.IsDate(New Object))
            Assert.IsTrue(Information.IsDate(New DateTime))
            Assert.IsFalse(Information.IsDate(New TimeSpan))
        End Sub

        <Test> Public Sub ControlCharsTest()
            Assert.AreEqual(ChrW(13) & ChrW(10), ControlChars.CrLf)
            Assert.AreEqual(ChrW(13), ControlChars.Cr)
            Assert.AreEqual(ChrW(10), ControlChars.Lf)
            Assert.AreEqual(ChrW(9), ControlChars.Tab)
        End Sub

        <Test> Public Sub TriStateTest()
            Assert.AreEqual(-2, CType(TriState.UseDefault, Integer))
            Assert.AreEqual(-1, CType(TriState.True, Integer))
            Assert.AreEqual(0, CType(TriState.False, Integer))
        End Sub

    End Class

End Namespace