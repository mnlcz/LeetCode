<?php

class Solution
{
    public function twoSum(array $nums, int $target): array
    {
        $diffs = [];

        for ($i = 0; $i < count($nums); $i++) {
            $diff = $target - $nums[$i];

            if (array_key_exists($diff, $diffs)) {
                return [$diffs[$diff], $i];
            }

            $diffs[$nums[$i]] = $i;
        }

        return [];
    }
}
