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

let groupAnagrams = strs => {
  // key: first word; value: word and anagrams
  let map = new Map()
  for (const s of strs) {
    // if map is empty add the first key
    if (map.size === 0) {
      map.set(s, [s])
    } else {
      // check if s is anagram of any key of map
      let [validAnagram, anagramKey] = [false, undefined]
      for (let k of map.keys()) {
        if (isAnagram(k, s)) {
          [validAnagram, anagramKey] = [true, k]
          break
        }
      }
      // if true then append s to anagrams value
      if (validAnagram) {
        map.get(anagramKey).push(s)
      }
      // else set a new entry on the map
      else {
        map.set(s, [s])
      }
    }
  }
  return Array.from(map.values())
}

const strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
console.log(groupAnagrams(strs))