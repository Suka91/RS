import sys
from Tuples_Solved import tuples

def main():
    with open('Tuples_IO.txt', 'r') as f:
        input_data = [int(i) for i in f.readline().split(',')]
        output_data = tuple([int(i) for i in f.readline().split(',')])
        result = tuples(input_data)
        print(result)
        if(result == output_data):
            print("T")
            sys.exit(0)
        print("F")
        sys.exit(1)

if __name__ == "__main__":
    main()
