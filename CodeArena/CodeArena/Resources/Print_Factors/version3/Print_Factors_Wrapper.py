import sys
from Print_Factors_Solved import compute_factors

def main():
    with open('Print_Factors_IO.txt', 'r') as f:
        input_data = int(f.readline())
        output_data = [int(i) for i in f.readline().split(',')]
        result = compute_factors(input_data)
        for i in range(len(output_data)):
            if output_data[i] != result[i]:
                print("F")
                sys.exit(1)
        print("T")
        sys.exit(0)

if __name__ == "__main__":
    main()
