import sys
from LCM_Solved import lcm

def main():
    with open('LCM_IO.txt', 'r') as f:
        input_data = f.readline().split(',')
        output_data = int(f.readline())
        if output_data != lcm(int(input_data[0]),int(input_data[1])):
            print("F")
            sys.exit(1)
        print("T")
        sys.exit(0)


if __name__ == "__main__":
    main()
