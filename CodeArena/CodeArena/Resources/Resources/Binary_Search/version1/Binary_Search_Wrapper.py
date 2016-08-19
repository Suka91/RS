import math
import sys
from Binary_Search_Solved import bin_search

def main():
    with open('Binary_Search_IO.txt', 'r') as f:
        input_data = f.readline()
        output_data = f.readline()
        tmp_string = input_data.split(';')
        input_list = [ int(i) for i in list(tmp_string[0].split(',')) ]
        input_element = int(tmp_string[1])
        result = bin_search(input_list, input_element)
        if(int(output_data) == result):
            sys.exit(0)
        else:
            sys.exit(-1)

if __name__ == "__main__":
    main()
