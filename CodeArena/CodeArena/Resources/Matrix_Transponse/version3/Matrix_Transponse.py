def matrix_transpose(X):
    return [[X[i][j] for j in range(len(X[0]))] for i in range(len(X))]
