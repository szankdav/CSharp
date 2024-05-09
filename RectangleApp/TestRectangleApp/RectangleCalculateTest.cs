using RectangleApp;

namespace TestRectangleApp
{
    // Fontos szab�lyok: 
    // 1. k�telez�en void-os
    // 2. egy teszt egy dolgot ellen�riz, 1 asserttel (ugyan�gy, mint 1 met�dus 1 dolgot csin�l)
    // 3. CC szab�lyait tartsuk be �s jobb es�llyel �runk j�l m�k�d� teszteket
    // 4. p�r soros legyen max.
    // 5. nem jav�tja ki a hib�t, csak hiba megl�t�t fedezi fel
    // 6. nem egyenl� a debuggol�ssal
    // 7. nincsen hibamentes rendszer
    // 8. a szoftver megb�zhat�s�g�t �s min�s�g�t n�veli
    // 9.  [TestClass]-al lehet l�trehozni
    // 10. C# TestSDK-t rakjuk a projekthez (Packages)-n�l jelenjen meg
    // Tob�bbi Szab�lyok:
    // A tesztel�sre sz�nt oszt�lyunkban k�telez� a [TestClass] attributum
    // A tesztel� met�dusn�l k�telez� a [TestMethod] attributum, de lehetnek
    // egy�b egyszer� met�dusok az oszt�lyon bel�l, melyek nem tesztek.
    // A tesztel� met�dus k�telez�en void-os �s nem lehet param�tere!!!

    [TestClass]
    public class RectangleCalculateTest
    {
        [TestMethod]
        public void testGetRectanglePerimeter()
        {
            RectangleCalculate rectObj = new RectangleCalculate();
            int actual = rectObj.getRectanglePerimeter(2, 3);
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void testGetRectangleArea() 
        {
            RectangleCalculate rectObj = new RectangleCalculate();
            int actual = rectObj.getRectangleArea(2, 3);
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }
    }
}