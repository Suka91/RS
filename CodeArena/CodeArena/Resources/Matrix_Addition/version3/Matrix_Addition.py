def matrix_addition(X,Y):
    return [[X[i][j]+Y[i][j] for j in range(len(X[0]))] for i in range(len(X))]
