let data = [[0 ,8, 3, 5, 5], [7, 0, 2, 3, 7], [3, 2, 0, 3, 7], [7, 3, 7, 0, 1], [3, 7, 4, 2, 0]]

for(let i = 0; i<5; i++) {
  for(let j = 0; j<5; j++) {
    if(i==j) { // 같으면 그냥 지나간다.
      continue
    }
    for(let k=0; k<5; k++) {
      if(k==i || k==j) {
        continue
      }
      if(data[i][j] > data[i][k] + data[k][j]) {
        data[i][j] = data[i][k] + data[k][j]
      }
    }
  }
}
console.log(data)