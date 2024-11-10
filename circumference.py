#original code found on https://github.com/LeoCroak/Random-things/blob/main/circumference.py
import math

diameter = input("Enter your diameter:")
unit = input("Enter your unit:")

while True:
    try:
        diameter = float(diameter)
        radius = diameter / 2
        break
    except ValueError:
        diameter = input("Enter a valid diameter:")

circumference = 2 * radius * math.pi

print(f"Your answer is {circumference}{unit}")