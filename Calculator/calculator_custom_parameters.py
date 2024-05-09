import unittest

class Calculator:
    def sum(self, a, b):
        return a + b

    def sub(self, a, b):
        return a - b

    def multiply(self, a, b):
        return a * b

    def divide(self, a, b):
        if b == 0:
            raise ZeroDivisionError("Nullával való osztás nem értelmezhető!")
        return a / b

class TestCalculator(unittest.TestCase):
    def setUp(self):
        self.calculation = Calculator()

    def test_add(self):
        print("Kérem írja be az 'a' számot az összeadáshoz:")
        a = int(input())
        print("Kérem írja be a 'b' számot az összeadáshoz:")
        b = int(input())

        result = self.calculation.sum(a, b)

        self.assertEqual(result, a + b)

    def test_subtract(self):
        print("Kérem írja be az 'a' számot a kivonáshoz:")
        a = int(input())
        print("Kérem írja be a 'b' számot a kivonáshoz:")
        b = int(input())

        result = self.calculation.sub(a, b)

        self.assertEqual(result, a - b)

    def test_multiply(self):
        print("Kérem írja be az 'a' számot a szorzáshoz:")
        a = int(input())
        print("Kérem írja be a 'b' számot a szorzához:")
        b = int(input())

        result = self.calculation.multiply(a, b)

        self.assertEqual(result, a * b)

    def test_divide(self):
        print("Kérem írja be az 'a' számot osztáshoz:")
        a = int(input())
        print("Kérem írja be a 'b' számot osztáshoz(0-tól különbözőt):")
        b = int(input())

        result = self.calculation.divide(a, b)

        self.assertEqual(result, a / b)

        if b == 0:
            self.assertRaises(ZeroDivisionError, self.calculation.divide, a, b)

if __name__ == '__main__':
    with open('test_custom_parameters_results.txt', 'w') as f:
        runner = unittest.TextTestRunner(stream=f, verbosity=2)
        unittest.main(testRunner=runner)
