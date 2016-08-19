import sys
from HCF_Solved import hcf

def main():
    with open('HCF_IO.txt', 'r') as f:
        input_data = f.readline().split(',')
        output_data = int(f.readline())
        if output_data != hcf(int(input_data[0]),int(input_data[1])):
            print("F")
            sys.exit(1)
        print("T")
        sys.exit(0)


if __name__ == "__main__":
    main()
