let isAnagram = (s, t) => {
  if (s.length !== t.length) return false
  let reps1 = new Map()
  let reps2 = new Map()
  for (let i = 0; i < s.length; i++) {
    let c1 = s[i], c2 = t[i]
    reps1.set(c1, reps1.has(c1) ? reps1.get(c1) + 1 : 1)
    reps2.set(c2, reps2.has(c2) ? reps2.get(c2) + 1 : 1)
  }
  for (const [key, val] of reps1)
    if (val !== reps2.get(key)) 
      return false
  return true
}