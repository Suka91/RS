import sys
from Palindrome_Solved import palindrome

def main():
    with open('Palindrome_IO.txt', 'r') as f:
        input_data = f.readline()
        output_data = int(f.readline())
        result = palindrome(input_data)
        if result == output_data:
            print("T")
            sys.exit(0)
        else:
            print("F")
            sys.exit(1)

if __name__ == "__main__":
    main()
