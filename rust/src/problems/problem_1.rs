// https://leetcode.com/problems/two-sum/description/
use std::collections::HashMap;

#[allow(dead_code)]
pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
    let mut diffs: HashMap<i32, usize> = HashMap::new();

    for (i, n) in nums.iter().enumerate() {
        let diff = target - n;

        match diffs.get(&diff) {
            Some(v) => return vec![*v as i32, i as i32],
            None => diffs.insert(*n, i),
        };
    }

    Vec::new()
}

#[cfg(test)]
mod tests {
    use super::two_sum;

    #[test]
    fn p1_1() {
        let res = two_sum(vec![2, 7, 11, 15], 9);
        assert_eq!(res, vec![0, 1]);
    }

    #[test]
    fn p1_2() {
        let res = two_sum(vec![3, 2, 4], 6);
        assert_eq!(res, vec![1, 2]);
    }

    #[test]
    fn p1_3() {
        let res = two_sum(vec![3, 3], 6);
        assert_eq!(res, vec![0, 1]);
    }
}
