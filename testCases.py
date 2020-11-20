Case1 = [
  [0, 1, 1, -2, -3],
  [1, 2, -1, 0, 2],
  [2, 4, 1 , -3, -2],
  [1, -4, -7, -1, 19]
]

Case2 = [
  [1, 0, -3, -2],
  [3, 1, -2, 5],
  [2, 2, 1,4]
]

Case3 =[
  [1, 2, -1, 0, 3],
  [2, 0, 2, 1, 4],
  [3, 1, 0, -1, 5]
]

def RREF(m):
  lead = 0
  rowSize = len(m)
  colSize = len(m[0])
  for row in range(rowSize):
    if (colSize <= lead): break
    i = row
    while (m[i][lead] == 0):
      i += 1
      if rowSize == i:
        i = row
        lead += 1
        if colSize == lead: break
    if i != row:
      for col in range(colSize):
        m[i][col], m[row][col] = m[row][col], m[i][col]
      for col in range(colSize):
        m[row][col] = m[row][col] / m[row][lead]
      j = i
      for j in range(rowSize):
        if (j  != row):
          for col in range(colSize):
            m[i][col] = m[i][col] - (m[i][lead] * m[row][col])
      lead += 1
  return m

def PrintMatrix(m):
  for i in m:
    print(i)
  print()

PrintMatrix(RREF(Case1))
PrintMatrix(RREF(Case2))
PrintMatrix(RREF(Case3))