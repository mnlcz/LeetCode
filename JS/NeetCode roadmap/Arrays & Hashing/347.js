const topKFrequent = (nums, k) => {
  let reps = new Map()
  nums.forEach(n => {
    if (reps.has(n)) {
      reps.set(n, reps.get(n) + 1)
    } else {
      reps.set(n, 1)
    }
  })
  return [...reps.entries()].sort((a, b) => b[1] - a[1]).slice(0, k).map(x => x[0])
}

// console.log(topKFrequent([1, 1, 1, 2, 2, 3], 2))
console.log(topKFrequent([3,0,1,0], 1))