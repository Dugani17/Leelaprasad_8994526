def is_equilateral_triangle(a, b, c):
    """ Function to check if the triangle with sides a, b, c is equilateral """
    return a == b == c and a > 0  # All sides are equal and greater than zero

# Test case 1: Positive scenario (should pass)
def test_equilateral_triangle_positive():
    assert is_equilateral_triangle(9, 5, 5) is True

# Test case 2: Negative scenario (should fail)
def test_equilateral_triangle_negative():
    assert is_equilateral_triangle(3, 4, 5) is False

if __name__ == "__main__":
    import pytest
    pytest.main()
