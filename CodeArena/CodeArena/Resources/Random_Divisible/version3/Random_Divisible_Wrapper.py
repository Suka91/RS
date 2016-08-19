import sys
from Random_Divisible_Solved import random_divisible

def main():
    with open('Random_Divisible_IO.txt', 'r') as f:
        input_data = f.readline().split(',')
        result = random_divisible(int(input_data[0]),int(input_data[1]))
        print(result)
        if(result < int(input_data[0]) or result > int(input_data[1])):
            print("F")
            sys.exit(1)
        if(result%5==0 and result%7==0):
            print("T")
            sys.exit(0)
        print("F")
        sys.exit(1)

if __name__ == "__main__":
    main()
