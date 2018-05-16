using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralConverter
{
    [TestClass]
    public class RomanNumeralExtensionTests
    {
        [TestMethod]
        public void ToRomanTests()
        {
            var minusOne = -1;
            Assert.AreEqual("Zero or Negative Value", 0.ToRoman(), "0: Bad Roman Test Failed");
            Assert.AreEqual("Zero or Negative Value", minusOne.ToRoman(), "-1: Bad Roman Test Failed");

            Assert.AreEqual("I", 1.ToRoman(), "I (1) Failed");
            Assert.AreEqual("II", 2.ToRoman(), "II (2) Failed");
            Assert.AreEqual("III", 3.ToRoman(), "III (3) Failed");
            Assert.AreEqual("IV", 4.ToRoman(), "IV (4) Failed");
            Assert.AreEqual("V", 5.ToRoman(), "V (5) Failed");
            Assert.AreEqual("VI", 6.ToRoman(), "VI (6) Failed");
            Assert.AreEqual("VII", 7.ToRoman(), "VII (7) Failed");
            Assert.AreEqual("VIII", 8.ToRoman(), "VIII (8) Failed");
            Assert.AreEqual("IX", 9.ToRoman(), "IX (9) Failed");
            Assert.AreEqual("X", 10.ToRoman(), "X (10) Failed");
            Assert.AreEqual("XI", 11.ToRoman(), "XI (11) Failed");
            Assert.AreEqual("XII", 12.ToRoman(), "XII (12) Failed");
            Assert.AreEqual("XIII", 13.ToRoman(), "XIII (13) Failed");
            Assert.AreEqual("XIV", 14.ToRoman(), "XIV (14) Failed");
            Assert.AreEqual("XV", 15.ToRoman(), "XV (15) Failed");
            Assert.AreEqual("XVI", 16.ToRoman(), "XVI (16) Failed");
            Assert.AreEqual("XVII", 17.ToRoman(), "XVII (17) Failed");
            Assert.AreEqual("XVIII", 18.ToRoman(), "XVIII (18) Failed");
            Assert.AreEqual("XIX", 19.ToRoman(), "XIX (19) Failed");
            Assert.AreEqual("XX", 20.ToRoman(), "XX (20) Failed");
            Assert.AreEqual("XXI", 21.ToRoman(), "XXI (21) Failed");
            Assert.AreEqual("XXII", 22.ToRoman(), "XXII (22) Failed");
            Assert.AreEqual("XXIII", 23.ToRoman(), "XXIII (23) Failed");
            Assert.AreEqual("XXIV", 24.ToRoman(), "XXIV (24) Failed");
            Assert.AreEqual("XXV", 25.ToRoman(), "XXV (25) Failed");
            Assert.AreEqual("XXVI", 26.ToRoman(), "XXVI (26) Failed");
            Assert.AreEqual("XXVII", 27.ToRoman(), "XXVII (27) Failed");
            Assert.AreEqual("XXVIII", 28.ToRoman(), "XXVIII (28) Failed");
            Assert.AreEqual("XXIX", 29.ToRoman(), "XXX (29) Failed");
            Assert.AreEqual("XXX", 30.ToRoman(), "XXX (30) Failed");
            Assert.AreEqual("MCMLXXVII", 1977.ToRoman(), "MCMLXXVII (1977) Failed");
            Assert.AreEqual("MCMLXXXIV", 1984.ToRoman(), "MCMLXXXIV (1984) Failed");
            Assert.AreEqual("MMXII", 2012.ToRoman(), "MMXII (2012) Failed");
        }

        [TestMethod]
        public void FromRomanTests()
        {
            Assert.AreEqual(0, "Some Old Scrap".FromRoman(), "Some Old Scrap: Bad Roman Test Failed");
            Assert.AreEqual(0, "0".FromRoman(), "0: Bad Roman Test Failed");
            Assert.AreEqual(0, "1".FromRoman(), "1: Bad Roman Test Failed");
            Assert.AreEqual(0, "A".FromRoman(), "A: Bad Roman Test Failed");
            Assert.AreEqual(0, "Z".FromRoman(), "Z: Bad Roman Test Failed");

            Assert.AreEqual(1, "I".FromRoman(), "1 (I) Failed");
            Assert.AreEqual(1, "i".FromRoman(), "1 (i) Failed");
            Assert.AreEqual(2, "II".FromRoman(), "2 (II) Failed");
            Assert.AreEqual(2, "ii".FromRoman(), "2 (ii) Failed");
            Assert.AreEqual(3, "III".FromRoman(), "3 (III) Failed");
            Assert.AreEqual(3, "iii".FromRoman(), "3 (iii) Failed");
            Assert.AreEqual(4, "IV".FromRoman(), "4 (IV) Failed");
            Assert.AreEqual(4, "iv".FromRoman(), "4 (iv) Failed");
            Assert.AreEqual(5, "V".FromRoman(), "5 (V) Failed");
            Assert.AreEqual(5, "v".FromRoman(), "5 (v) Failed");
            Assert.AreEqual(6, "VI".FromRoman(), "6 (VI) Failed");
            Assert.AreEqual(6, "vi".FromRoman(), "6 (vi) Failed");
            Assert.AreEqual(7, "VII".FromRoman(), "7 (VII) Failed");
            Assert.AreEqual(7, "vii".FromRoman(), "7 (vii) Failed");
            Assert.AreEqual(8, "VIII".FromRoman(), "8 (VIII) Failed");
            Assert.AreEqual(8, "viii".FromRoman(), "8 (viii) Failed");
            Assert.AreEqual(9, "IX".FromRoman(), "9 (IX) Failed");
            Assert.AreEqual(9, "ix".FromRoman(), "9 (ix) Failed");
            Assert.AreEqual(10, "X".FromRoman(), "10 (X) Failed");
            Assert.AreEqual(10, "x".FromRoman(), "10 (x) Failed");
            Assert.AreEqual(1977, "MCMLXXVII".FromRoman(), "1977 (MCMLXXVII) Failed");
            Assert.AreEqual(1977, "mcmlxxvii".FromRoman(), "1977 (mcmlxxvii) Failed");
            Assert.AreEqual(1977, "McMLXxViI".FromRoman(), "1977 (McMLXxViI) Failed");
            Assert.AreEqual(1984, "MCMLXXXIV".FromRoman(), "1984 (MCMLXXXIV) Failed");
            Assert.AreEqual(1984, "mcmlxxxiv".FromRoman(), "1984 (mcmlxxxiv) Failed");
            Assert.AreEqual(2012, "MMXII".FromRoman(), "2012 (MMXII) Failed");
            Assert.AreEqual(2012, "MMxII".FromRoman(), "2012 (MMxII) Failed");

        }

        [TestMethod]
        public void RomanFunctionToFunctionTests()
        {
            for (int i = 1; i < 10001; i++)
            {
                var toRoman = i.ToRoman();
                var fromRoman = toRoman.FromRoman();
                Assert.AreEqual(fromRoman, i, string.Format("{0} ({1}) Failed", toRoman, i));
            }
        }
    }
}
