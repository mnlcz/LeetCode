// https://leetcode.com/problems/valid-anagram/description/
use std::collections::HashMap;

#[allow(dead_code)]
pub fn is_anagram(s: String, t: String) -> bool {
    if s.len() != t.len() {
        return false;
    }
    if s.len() == 1 {
        return s.chars().next().unwrap() == t.chars().next().unwrap();
    }

    let hm1 = fill_hm(&s);
    let hm2 = fill_hm(&t);

    for (k, v) in hm1 {
        if let Some(&val) = hm2.get(&k) {
            if val != v {
                return false;
            }
        } else {
            return false;
        }
    }

    true
}

fn fill_hm(s: &str) -> HashMap<char, i32> {
    let mut hm: HashMap<char, i32> = HashMap::new();
    
    for c in s.chars() {
        if hm.contains_key(&c) {
            if let Some(cnt) = hm.get_mut(&c) {
                *cnt += 1;
            }
        } else {
            hm.insert(c, 1);
        }
    }

    hm
}

#[cfg(test)]
mod tests {
    use crate::problems::problem_242::is_anagram;

    #[test]
    fn p242_1() {
        assert!(is_anagram("anagram".to_string(), "nagaram".to_string()));
    } 

    #[test]
    fn p242_2() {
        assert!(!is_anagram("rat".to_string(), "car".to_string()));
    }
}
