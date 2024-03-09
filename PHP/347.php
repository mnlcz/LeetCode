<?php

// https://leetcode.com/problems/top-k-frequent-elements/description/

class Solution
{
    public function topKFrequent(array $nums, int $k): array
    {
        $reps = [];
        $k_frecuent = [];

        foreach ($nums as $n) {
            if (isset($reps[$n])) {
                $reps[$n]++;
            } else {
                $reps[$n] = 1;
            }
        }

        asort($reps);

        while ($k-- > 0) {
            $keys = array_keys($reps);
            $last_key = end($keys);
            unset($reps[$last_key]);
            $k_frecuent[] = $last_key;
        }

        return $k_frecuent;
    }
}
