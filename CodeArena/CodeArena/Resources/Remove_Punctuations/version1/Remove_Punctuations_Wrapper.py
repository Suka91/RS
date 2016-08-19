import sys
from Remove_Punctuations_Solved import remove_punctuations

def main():
    with open('Remove_Punctuations_IO.txt', 'r') as f:
        input_data = f.readline()
        output_data = f.readline()
        result = remove_punctuations(input_data)
        result = result.strip()
        print(result)
        if(result == output_data):
            print("T")
            sys.exit(0)
        print("F")
        sys.exit(1)

if __name__ == "__main__":
    main()
