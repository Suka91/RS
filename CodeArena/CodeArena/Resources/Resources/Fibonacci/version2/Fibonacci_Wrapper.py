import sys
from Fibonacci_Solved import recur_fibo

def main():
    with open('Fibonacci_IO.txt', 'r') as f:
        input_data = int(f.readline())
        output_data = int(f.readline())
        if output_data != recur_fibo(input_data):
            print("F")
            sys.exit(1)
        print("T")
        sys.exit(0)


if __name__ == "__main__":
    main()
