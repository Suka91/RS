import sys
from Math_Formula_Solved import math_formula

def main():
    with open('Math_Formula_IO.txt', 'r') as f:
        input_data = f.readline().split(';')
        input_list = [ int(i) for i in list(input_data[0].split(','))]
        output_data = [ int(i) for i in list(f.readline().split(','))]
        result = []
        result = math_formula(input_list,int(input_data[1]),int(input_data[2]))
        for i in range(len(output_data)):
            if output_data[i] != result[i]:
                print("F")
                sys.exit(1)
        print("T")
        sys.exit(0)


if __name__ == "__main__":
    main()
