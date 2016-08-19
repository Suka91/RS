import sys
from Dec_To_Bin_Solved import binary

def main():
    with open('Dec_To_Bin_IO.txt', 'r') as f:
        input_data = f.readline()
        output_data = f.readline()
        list_tmp = []
        result = str(binary(int(input_data),list_tmp))
        print(result)
        print(output_data)
        if output_data.casefold().strip() == result.casefold().strip():
            print("T")
            sys.exit(0)
        else:
            print("F")
            sys.exit(1)


if __name__ == "__main__":
    main()
