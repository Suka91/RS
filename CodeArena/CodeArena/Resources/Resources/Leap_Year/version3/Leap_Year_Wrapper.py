import sys
from Leap_Year_Solved import leap_year

def main():
    with open('Leap_Year_IO.txt', 'r') as f:
        input_data = int(f.readline())
        output_data = int(f.readline())
        if output_data != leap_year(input_data):
            print("F")
            sys.exit(1)
        print("T")
        sys.exit(0)


if __name__ == "__main__":
    main()
