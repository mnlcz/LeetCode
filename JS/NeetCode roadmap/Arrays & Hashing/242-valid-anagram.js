let isAnagram = (s, t) => {
  if (s.length !== t.length) return false
  let reps1 = {}
  let reps2 = {}
  for (let i = 0; i < s.length; i++) {
    let c1 = s[i], c2 = t[i]
    reps1[c1] = c1 in reps1 ? reps1[c1] + 1 : 1
    reps2[c2] = c2 in reps2 ? reps2[c2] + 1 : 1
  }
  for (c in reps1) {
    if (reps1[c] !== reps2[c]) return false
  }
  return true
}