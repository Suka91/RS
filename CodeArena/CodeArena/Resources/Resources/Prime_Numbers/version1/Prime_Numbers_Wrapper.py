import sys
from Prime_Numbers_Solved import prime_numbers

def main():
    with open('Prime_Numbers_IO.txt', 'r') as f:
        input_data = f.readline().split(',')
        output_data = [int(i) for i in f.readline().split(',')]
        result = prime_numbers(int(input_data[0]),int(input_data[1]))
        for i in range(len(output_data)):
            if output_data[i] != result[i]:
                print("F")
                sys.exit(1)
        print("T")
        sys.exit(0)

if __name__ == "__main__":
    main()
