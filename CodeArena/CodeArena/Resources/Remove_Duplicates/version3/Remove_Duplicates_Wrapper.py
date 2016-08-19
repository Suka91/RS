import sys
from Remove_Duplicates_Solved import remove_duplicates

def main():
    with open('Remove_Duplicates_IO.txt', 'r') as f:
        input_data = f.readline()
        output_data = f.readline()
        result = remove_duplicates(input_data)
        result = result.strip()
        print(result)
        if(result == output_data):
            print("T")
            sys.exit(0)
        print("F")
        sys.exit(1)

if __name__ == "__main__":
    main()
