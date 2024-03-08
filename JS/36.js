const isValidSudoku = (board) => {
  let set = new Set()
  // filas
  for (let i = 0; i < 9; i++) {
    set.clear()
    for (let j = 0; j < 9; j++) {
      let item = board[i][j]
      if (item !== '.' && set.has(item)) return false
      set.add(item)
    }
  }
  // columnas
  for (let i = 0; i < 9; i++) {
    set.clear()
    for (let j = 0; j < 9; j++) {
      let item = board[j][i]
      if (item !== '.' && set.has(item)) return false
      set.add(item)
    }
  }
  // 3x3
  for (let i = 0; i < 9; i += 3) {
    for (let j = 0; j < 9; j += 3) {
      set.clear()
      for (let i2 = 0; i2 < 3; i2++) {
        for (let j2 = 0; j2 < 3; j2++) {
          let item = board[i + i2][j + j2]
          if (item !== '.' && set.has(item)) return false
          set.add(item)
        }
      }
    }
  }
  return true
}