import sys
from Pow_Numbers_Solved import pow_numbers

def main():
    with open('Pow_Numbers_IO.txt', 'r') as f:
        input_data = f.readline().split(';')
        in_list = [int(i) for i in input_data[0].split(',')]
        degree = int(input_data[1])
        output_data = [int(i) for i in f.readline().split(',')]
        result = pow_numbers(in_list,degree)
        print(result)
        print(output_data)
        if result == output_data:
            print("T")
            sys.exit(0)
        else:
            print("F")
            sys.exit(1)

if __name__ == "__main__":
    main()
