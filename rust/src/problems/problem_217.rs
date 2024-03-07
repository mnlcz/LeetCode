// https://leetcode.com/problems/contains-duplicate/description/
use std::collections::HashMap;

#[allow(dead_code)]
pub fn contains_duplicate(nums: Vec<i32>) -> bool {
    let mut hm: HashMap<i32, bool> = HashMap::new();

    for n in nums {
        if hm.contains_key(&n) {
            return true;
        }
        hm.insert(n, true);
    }

    false
}

#[cfg(test)]
mod tests {
    use crate::problems::problem_217::contains_duplicate;

    #[test]
    fn p217() {
        assert_eq!(contains_duplicate(vec![1, 2, 3, 1]), true);
        assert_eq!(contains_duplicate(vec![1, 2, 3, 4]), false);
        assert_eq!(contains_duplicate(vec![1, 1, 1, 3, 3, 4, 3, 2, 4, 2]), true);
    }
}
