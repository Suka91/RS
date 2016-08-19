import sys
from Matrix_Transponse_Solved import matrix_transpose

def main():
    with open('Matrix_Transponse_IO.txt', 'r') as f:
        temp_data = [ i for i in list(f.readline().split(';'))]
        input_data = []

        for i in range(len(temp_data)):
            input_data.append([ int(i) for i in list(temp_data[i].split(','))])

        output_data = []
        temp_data = [ i for i in list(f.readline().split(';'))]
        for i in range(len(temp_data)):
            output_data.append([ int(i) for i in list(temp_data[i].split(','))])
        result = []
        result = matrix_transpose(input_data)

        print(result)
        print(output_data)
        for i in range(len(result)):
            for j in range(len(result[i])):
                if output_data[i][j] != result[i][j]:
                    print("F")
                    sys.exit(1)
        print("T")
        sys.exit(0)

if __name__ == "__main__":
    main()
