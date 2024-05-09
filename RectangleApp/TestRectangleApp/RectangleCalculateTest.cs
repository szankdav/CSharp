using RectangleApp;

namespace TestRectangleApp
{
    // Fontos szabályok: 
    // 1. kötelezõen void-os
    // 2. egy teszt egy dolgot ellenõriz, 1 asserttel (ugyanúgy, mint 1 metódus 1 dolgot csinál)
    // 3. CC szabályait tartsuk be és jobb eséllyel írunk jól mûködõ teszteket
    // 4. pár soros legyen max.
    // 5. nem javítja ki a hibát, csak hiba meglétét fedezi fel
    // 6. nem egyenlõ a debuggolással
    // 7. nincsen hibamentes rendszer
    // 8. a szoftver megbízhatóságát és minõségét növeli
    // 9.  [TestClass]-al lehet létrehozni
    // 10. C# TestSDK-t rakjuk a projekthez (Packages)-nél jelenjen meg
    // Tobábbi Szabályok:
    // A tesztelésre szánt osztályunkban kötelezõ a [TestClass] attributum
    // A tesztelõ metódusnál kötelezõ a [TestMethod] attributum, de lehetnek
    // egyéb egyszerû metódusok az osztályon belül, melyek nem tesztek.
    // A tesztelõ metódus kötelezõen void-os és nem lehet paramétere!!!

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