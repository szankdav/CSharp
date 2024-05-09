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

class CalculatorTest(unittest.TestCase):
    def setUp(self):
        self.calculation = Calculator()

    def test_add(self):
        a = 7
        b = 3

        result = self.calculation.sum(a, b)

        self.assertEqual(result, 10)

    def test_subtract(self):
        a = 7
        b = 3

        result = self.calculation.sub(a, b)

        self.assertEqual(result, 4)

    def test_multiply(self):
        a = 7
        b = 3

        result = self.calculation.multiply(a, b)

        self.assertEqual(result, 21)

    def test_divide(self):
        a = 7
        b = 3

        result = self.calculation.divide(a, b)

        self.assertEqual(result, 2.3333333333333335)

        with self.assertRaises(ZeroDivisionError):
            self.calculation.divide(10, 0)

if __name__ == '__main__':
    with open('calculator_test_results.txt', 'w') as f:
        runner = unittest.TextTestRunner(stream=f, verbosity=2)
        unittest.main(testRunner=runner)