import sys
from Even_Numbers_Solved import even_numbers

def main():
    with open('Even_Numbers_IO.txt', 'r') as f:
        input_data = [ int(i) for i in list(f.readline().split(','))]
        output_data = [ int(i) for i in list(f.readline().split(','))]
        result = []
        result = even_numbers(input_data)
        for i in range(len(output_data)):
            if output_data[i] != result[i]:
                print("F")
                sys.exit(1)
        print("T")
        sys.exit(0)


if __name__ == "__main__":
    main()
