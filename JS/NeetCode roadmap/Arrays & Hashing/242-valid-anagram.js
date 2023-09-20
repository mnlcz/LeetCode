let isAnagram = (s, t) => {
  if (s.length !== t.length) return false
  let reps1 = {}
  let reps2 = {}
  for (let c of s) {
    reps1[c] = c in reps1 ? reps1[c] + 1 : 1
  }
  for (let c of t) {
    reps2[c] = c in reps2 ? reps2[c] + 1 : 1
  }
  for (c in reps1) {
    if (reps1[c] !== reps2[c]) return false
  }
  return true
}

console.log(isAnagram("anagram", "nagaram"))
console.log(isAnagram("rat", "car"))