#original code found on https://github.com/LeoCroak/Random-things/blob/main/calculatorlogic.py

num1 = input("Enter your first number:")
symbol = input("enter your operator:")
num2 = input("Enter your second number:")

#checks if values are empty

while True:
    try:
        num1 = float(num1)
        break
    except ValueError:
        num1 = input("Invalid input. enter a number:")

while symbol not in ["*", "/", "-", "+"]:
    symbol = input("Enter your operator (+, -, /, *):")

while True:
    try:
        num2 = float(num2)
        break
    except ValueError:
        num2 = input("Invalid input.Enter your second number:")


#performs the actual maths

if symbol == "*": #multiplication
    print(f"Your answer is {num1 * num2}:")
elif symbol == "/": #division also checks for division by zero
    if num2 == 0:
       print("Error you cannot divide by 0:")
    else:
        print(f"Your answer is {num1 / num2}:")
elif symbol == "-": #subtraction
    print(f"your answer is {num1 - num2}:")
elif symbol == "+": #addition
    print(f"Your answer is {num1 + num2}:")
else: #in case of an error
    print("There was a error:")