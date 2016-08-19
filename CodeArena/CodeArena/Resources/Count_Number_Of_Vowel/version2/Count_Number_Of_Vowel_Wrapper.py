import sys
import ast
from Count_Number_Of_Vowel_Solved import count_number_of_vowel

def main():
    with open('Count_Number_Of_Vowel_IO.txt', 'r') as f:
        input_data = f.readline()
        output_data = ast.literal_eval(f.readline())
        result = count_number_of_vowel(input_data)
        for key in output_data:
            if int(output_data[key]) != result[key]:
                sys.exit(-1)
        else:
            sys.exit(0)


if __name__ == "__main__":
    main()
