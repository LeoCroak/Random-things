# original code found on https://github.com/LeoCroak/Random-things/blob/main/circumference.py
import math

diameter = float(input("Enter your diameter:"))
radius = diameter / 2
unit = input("Enter your unit:")

circumference = 2 * radius * math.pi

print(f"Your answer is {circumference}{unit}")