import sys
from Factorial_Solved import factorial

def main():
    with open('Factorial_IO.txt', 'r') as f:
        input_data = int(f.readline())
        output_data = int(f.readline())
        if output_data != factorial(input_data):
            print("F")
            sys.exit(1)
        print("T")
        sys.exit(0)


if __name__ == "__main__":
    main()
