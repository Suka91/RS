import sys
from Matrix_Addition_Solved import matrix_addition

def main():
    with open('Matrix_Addition_IO.txt', 'r') as f:
        temp_data = [ i for i in list(f.readline().split(';'))]
        input_data1 = []

        for i in range(len(temp_data)):
            input_data1.append([ int(i) for i in list(temp_data[i].split(','))])

        temp_data = [ i for i in list(f.readline().split(';'))]
        input_data2 = []

        for i in range(len(temp_data)):
            input_data2.append([ int(i) for i in list(temp_data[i].split(','))])

        output_data = []
        temp_data = [ i for i in list(f.readline().split(';'))]
        for i in range(len(temp_data)):
            output_data.append([ int(i) for i in list(temp_data[i].split(','))])
        result = []
        result = matrix_addition(input_data1, input_data2)

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
